using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Helpers;

namespace APITest
{
    public partial class Form1 : Form
    {
        private string _testApiBaseUrl = "http://localhost:65152/api/test";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtApiPath.Text = _testApiBaseUrl;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
        }

        private bool IsApiPathAvailable()
        {
            if(string.IsNullOrWhiteSpace(txtApiPath.Text))
            {
                var response = MessageBox.Show("API path missing. Do you want to use the default path?", "API Path Missing", MessageBoxButtons.YesNo);
                if(response == DialogResult.Yes)
                {
                    txtApiPath.Text = _testApiBaseUrl;
                }
                else
                {
                    return false;
                }
            }

            if (txtApiPath.Text.EndsWith("/"))
            {
                txtApiPath.Text = txtApiPath.Text.Remove(txtApiPath.Text.Length - 1);
            }

            return true;
        }

        //standard post
        private void btnTestApiPost_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return;

            btnClear.PerformClick();
            DoPost();
        }

        private async void DoPost()
        {
            var dp = new  DummyPost { Id = 12345, Name = "XYZ" };
            //we might be posting one model and getting back another model. Here the same model is getting posted. So .Post<inputModel Type, returnModel Type>
            var apiCallResult = await ApiCrudCallHelper.Post<DummyPost, DummyPost>(dp, txtApiPath.Text);
            txtResults.AppendText(apiCallResult.Message);
        }

        //post to custom action
        private void btnTestApiPostExtra_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return;

            btnClear.PerformClick();
            DoPostExtra();
        }

        private async void DoPostExtra()
        {
            var dp = new DummyPost { Id = 12345, Name = "XYZ" };
            //we might be posting one model and getting back another model. Here the same model is getting posted. So .Post<inputModel Type, returnModel Type>
            var apiUrl = $"{txtApiPath.Text}/ExtraPost";
            var apiCallResult = await ApiCrudCallHelper.Post<DummyPost, DummyPost>(dp, apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //post to custom action and getting ok result back 
        private void btnTestApiPostExtraOkResult_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return;

            btnClear.PerformClick();
            DoPostExtraOkResult();
        }

        private async void DoPostExtraOkResult()
        {
            var dp = new DummyPost { Id = 12345, Name = "XYZ" };
            //we might be posting one model and getting back another model. Here the same model is getting posted. So .Post<inputModel Type, returnModel Type>
            var apiUrl =$"{txtApiPath.Text}/ExtraPostOk";
            var apiCallResult = await ApiCrudCallHelper.Post<DummyPost, string>(dp, apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //post with multiline model return
        private void btnTestApiPostExtraMultiLine_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return; 

            btnClear.PerformClick();
            DoPostExtraMultiLineReturn();
        }

        private async void DoPostExtraMultiLineReturn()
        {
            var dp = new DummyPost { Id = 12345, Name = "XYZ" };
            //we might be posting one model and getting back another model. Here the same model is getting posted. So .Post<inputModel Type, returnModel Type>
            var apiUrl = $"{txtApiPath.Text}/ExtraPostMultiLineReturn";
            var apiCallResult = await ApiCrudCallHelper.Post<DummyPost, List<DummyPost>>(dp, apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //standard put
        private void btnTestApiPut_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return; 

            btnClear.PerformClick();
            DoPut();
        }

        private async void DoPut()
        {
            var dp = new DummyPost { Id = 12345, Name = "XYZ" };
            //we might be posting one model and getting back another model. Here the same model is getting posted. So .Post<inputModel Type, returnModel Type>
            //since this is a PUT call, append the id to the url as well
            var apiUrl = $"{txtApiPath.Text}/98745";
            var apiCallResult = await ApiCrudCallHelper.Put<DummyPost, DummyPost>(dp, apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //standard delete
        private void btnTestApiDelete_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return;

            btnClear.PerformClick();
            DoDelete();
        }

        private async void DoDelete()
        {
            //not posting any model, should get back a string responce but we can get a model as well (why?)
            //since this is a DELETE call, append the id to the url as well
            var apiUrl = $"{txtApiPath.Text}/98745";
            var apiCallResult = await ApiCrudCallHelper.Delete<string>(apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //standard get
        private void btnTestApiGet_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return; 

            btnClear.PerformClick();
            DoGet();
        }

        private async void DoGet()
        {
            var apiUrl = txtApiPath.Text;
            var apiCallResult = await ApiCrudCallHelper.Get<string>(apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //get by id
        private void btnTestApiGetId_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return;

            btnClear.PerformClick();
            var apiUrl = $"{txtApiPath.Text}/98745";
            DoGetId();
        }

        private async void DoGetId()
        {
            var apiUrl = $"{txtApiPath.Text}/98745";
            var apiCallResult = await ApiCrudCallHelper.Get<string>(apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        //custom get action
        private void btnTestApiGetAll_Click(object sender, EventArgs e)
        {
            if (!IsApiPathAvailable()) return;

            btnClear.PerformClick();
            DoGetAll();
        }

        private async void DoGetAll()
        {
            var apiUrl = $"{txtApiPath.Text}/All";
            var apiCallResult = await ApiCrudCallHelper.Get<List<DummyPost>>(apiUrl);
            txtResults.AppendText(apiCallResult.Message);
        }

        
    }
}
