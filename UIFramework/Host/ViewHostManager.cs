using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIFramework.Core;

namespace UIFramework.Host
{
    /// <summary>
    /// 提供頁面註冊與切換功能的管理器。
    /// 專注於 Panel 中的 UserControl 容器切換，不負責 Menu 或 Theme 管理。
    /// </summary>
    public class ViewHostManager : IViewHost
    {
        private readonly Panel _container;
        private readonly Dictionary<string, UserControl> _views = new Dictionary<string, UserControl>();

        /// <summary>
        /// 目前顯示的頁面 Key。
        /// </summary>
        public string CurrentViewKey { get; private set; }

        /// <summary>
        /// 當頁面切換時觸發，參數為新頁面的 Key。
        /// </summary>
        public event Action<string> ViewSwitched;

        /// <summary>
        /// 建立 ViewHostManager 實例。
        /// </summary>
        /// <param name="container">作為頁面顯示容器的 Panel。</param>
        /// <exception cref="ArgumentNullException">當容器為 null 時拋出。</exception>
        public ViewHostManager(Panel container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        /// <summary>
        /// 註冊頁面至容器。
        /// </summary>
        /// <param name="key">頁面唯一識別字。</param>
        /// <param name="view">欲顯示的 UserControl 實例。</param>
        /// <exception cref="ArgumentException">當 key 為空或 null 時拋出。</exception>
        public void Register(string key, UserControl view)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be null or empty.", nameof(key));

            if (!_views.ContainsKey(key))
                _views[key] = view;
        }

        /// <summary>
        /// 切換至指定頁面。
        /// </summary>
        /// <param name="key">要切換的頁面 Key。</param>
        /// <exception cref="InvalidOperationException">當指定頁面尚未註冊時拋出。</exception>
        public void Switch(string key)
        {
            if (!_views.ContainsKey(key))
                throw new InvalidOperationException($"View '{key}' is not registered.");

            _container.Controls.Clear();
            _container.Controls.Add(_views[key]);
            _views[key].Dock = DockStyle.Fill;
            CurrentViewKey = key;
            ViewSwitched?.Invoke(key);
        }
    }


}
