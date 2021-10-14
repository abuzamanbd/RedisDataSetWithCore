using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using RedisTest.Services;
using Services.Model;

namespace RegisDataManagerForm
{
    public partial class Form1 : Form
    {
        private readonly CacheStrigsStack _cacheStrigsStack;
        public Form1(CacheStrigsStack cacheStaringsStack)
        {

            IKernel kernel = new StandardKernel();
            _cacheStrigsStack = new CacheStrigsStack(null,kernel);
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string id = DId.Text;
            string clientId = ClientId.Text;
            string depositAmount = DepositAmt.Text;

            DepositInfoModel depositInfoModel = new DepositInfoModel()
            {
                Id = id,
                ClientId = clientId,
                DepositAmount = depositAmount
            };
            _cacheStrigsStack.InsertInfoToRedis(depositInfoModel);
            DId.Text = "";
            ClientId.Text = "";
            DepositAmt.Text = "";

        }

        private void ClientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {
            string clientId = textBox1.Text;
            var data = _cacheStrigsStack.CheckKeyExists(clientId);

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = data;

            dataGridView1.DataSource = bindingSource1;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string clientId = textBox1.Text;
            _cacheStrigsStack.DeleteKey(clientId);
            textBox1.Text = "";
        }
    }
}
