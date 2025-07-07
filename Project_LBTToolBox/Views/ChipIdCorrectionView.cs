using Project_LBTToolBox.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views
{
    public partial class ChipIdCorrectionView : UserControl, IChipIdCorrectionViewPack
    {
        public Button BtnBrowse => btnBrowse;
        public TextBox TextFolderPath => txtFolderPath;
        public Button BtnApplyFix => btnApplyFix;
        public TextBox TextBoxIndex => txtIndex;
        public TextBox TextBoxOCR => txtOCR;
        public DataGridView DgvChipList => dgvChipList;

        IChipIdCorrectionViewPack _pack;

        public ChipIdCorrectionView(IChipIdCorrectionViewPack pack)
        {
            InitializeComponent();

            _pack = pack;
        }
    }
}
