using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OKCoinAPI;

namespace OKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Test();
            InitializeComponent();
        }

        void Test()
        {
            //填写API key
            string api_key = "";
            string secret_key = "";

            OKCoin ok = new OKCoin(api_key, secret_key);
            //ok.GetTicker();
            //ok.GetDepth();
            //ok.GetUserInfo();
            //ok.OrderInfo("-1");
            //ok.CancelOrder("109696287");
            //ok.Trade(new Trade(TradeType.buy, Decimal.Parse("10.7"), Decimal.Parse("0.1")));
            

        }

    }
}
