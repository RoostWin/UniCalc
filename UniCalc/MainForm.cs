using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniCalc.BE.Enum;
using UniCalc.BL;

namespace UniCalc
{
    public partial class MainForm : Form
    {
        private LogicBL _logicBL;
        private LogicBL LogicBL
        {
            get
            {
                if (_logicBL == null)
                {
                    _logicBL = new LogicBL();
                }
                return _logicBL;
            }
        }
        
        #region Параметры формы

        private LogicType _logic;
        private long x1;
        private long x2;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Нажатие кнопок

        private void button1_Click(object sender, EventArgs e)
        {
            tbData.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbData.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbData.Text += "3";
        }


        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            _logic = LogicType.plus;
            Int64.TryParse(tbData.Text, out x1);
            tbData.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int64.TryParse(tbData.Text, out x2);
            
            
            switch (_logic)
            {
                case LogicType.plus:
                    tbData.Text = LogicBL.Plus(x1, x2);
                    break;

                case LogicType.minus:
                    //tbData.Text = LogicBL.Plus(x1, x2).ToString();
                    break;
            }

        }
    }
}
