using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab.ViewInfo;
using DXApplication1.model;
using DXApplication1.manage;
namespace DXApplication1
{
    public partial class index : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        User user = new User();
         public Dictionary<string, XtraTabPage> TabPageDic = new Dictionary<string, XtraTabPage>();

        public index(User u)
        {
            user = u;
            InitializeComponent();
           
            index_Load(null,null);
        }
        public bool IsXtraTabPageExsit(string tabPageName)
        {
            bool isExsit = false;//默认为不存在
            foreach (KeyValuePair<string, XtraTabPage> kvp in TabPageDic)
            {
                if (kvp.Key == tabPageName)
                {
                    xtraTabControl1.SelectedTabPage = kvp.Value;//若Page页存在，则设置为当前选中页
                    return true;
                }
            }
            return isExsit;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!user.role.Equals("管理员") || user.state.Equals("关闭"))
            {
                MessageBox.Show("你不是管理员或者你已禁用，请联系管理员","系统");
                return;
            }
            bool isTabPageExsit = IsXtraTabPageExsit("信息维护");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "信息维护";//设置新TabPage的Name
            newTabPage.Text = "信息维护";//设置新TabPage的标题文本

            Usermanage userInfoManagementForm = new Usermanage(this);//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {
            
                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("信息维护", newTabPage);
        }
        public void xtraTabControl1_CloseButtonClick_1(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs args = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = args.Page.Text;
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == name)
                {
                    xtraTabControl1.TabPages.Remove(page);
                    page.Dispose();
                    TabPageDic.Remove(name);//从字典中移除
                    return;
                }
            }
        }
        private void index_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前用户：" + user.username;
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (!user.role.Equals("管理员") || user.state.Equals("关闭"))
            {
                MessageBox.Show("你不是管理员或者你已禁用，请联系管理员", "系统");
                return;
            }
            bool isTabPageExsit = IsXtraTabPageExsit("供应商信息");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "供应商信息";//设置新TabPage的Name
            newTabPage.Text = "供应商信息";//设置新TabPage的标题文本

            gysmanage userInfoManagementForm = new gysmanage();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("供应商信息", newTabPage);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (!user.role.Equals("管理员") || user.state.Equals("关闭"))
            {
                MessageBox.Show("你不是管理员或者你已禁用，请联系管理员", "系统");
                return;
            }
            bool isTabPageExsit = IsXtraTabPageExsit("商品信息");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "商品信息";//设置新TabPage的Name
            newTabPage.Text = "商品信息";//设置新TabPage的标题文本

            goodsmanage userInfoManagementForm = new goodsmanage();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("商品信息", newTabPage);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!user.role.Equals("管理员") || user.state.Equals("关闭"))
            {
                MessageBox.Show("你不是管理员或者你已禁用，请联系管理员", "系统");
                return;
            }
            bool isTabPageExsit = IsXtraTabPageExsit("客户信息");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "客户信息";//设置新TabPage的Name
            newTabPage.Text = "客户信息";//设置新TabPage的标题文本

            clientmanage userInfoManagementForm = new clientmanage();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("客户信息", newTabPage);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isTabPageExsit = IsXtraTabPageExsit("仓库管理");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "仓库管理";//设置新TabPage的Name
            newTabPage.Text = "仓库管理";//设置新TabPage的标题文本

            warehousemanage userInfoManagementForm = new warehousemanage();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("仓库管理", newTabPage);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isTabPageExsit = IsXtraTabPageExsit("购货记录");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "购货记录";//设置新TabPage的Name
            newTabPage.Text = "购货记录";//设置新TabPage的标题文本

            purchaselist userInfoManagementForm = new purchaselist();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("购货记录", newTabPage);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isTabPageExsit = IsXtraTabPageExsit("购货订单");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "购货订单";//设置新TabPage的Name
            newTabPage.Text = "购货订单";//设置新TabPage的标题文本

            purchase userInfoManagementForm = new purchase();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("购货订单", newTabPage);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isTabPageExsit = IsXtraTabPageExsit("销售订单");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "销售订单";//设置新TabPage的Name
            newTabPage.Text = "销售订单";//设置新TabPage的标题文本

            sale userInfoManagementForm = new sale();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("销售订单", newTabPage);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             bool isTabPageExsit = IsXtraTabPageExsit("销售记录");
            XtraTabPage newTabPage = new XtraTabPage();

            newTabPage.Name = "销售记录";//设置新TabPage的Name
            newTabPage.Text = "销售记录";//设置新TabPage的标题文本

            salelist userInfoManagementForm = new salelist();//创建基本信息维护winform的对象
            //以下是设置winform的显示格式，属性等
            userInfoManagementForm.TopLevel = false;
            userInfoManagementForm.BackColor = Color.White;
            userInfoManagementForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoManagementForm.FormBorderStyle = FormBorderStyle.None;
            userInfoManagementForm.Dock = DockStyle.Fill;
            //以上是设置winform的显示格式，属性等
            userInfoManagementForm.Show();//显示窗体
            newTabPage.Controls.Add(userInfoManagementForm);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {

                return;
            }
            xtraTabControl1.TabPages.Add(newTabPage);//添加
            xtraTabControl1.SelectedTabPage = newTabPage;//设置为选中
            TabPageDic.Add("销售记录", newTabPage);
        }
    }
}
