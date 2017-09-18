﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassCollection;
using RibbonSupport;
using DevExpress.XtraSplashScreen;
using Library_System.Manage_Users;
using Library_System.Manage_Books;
using DevExpress.Utils;
using DevExpress.XtraBars;

namespace Library_System
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private RibbonSupportClass rsc;
        private SaveSender ss = SaveSender.None;
        public static string userLoggedIn = null;
        public static bool triggerDesigner = false;

        public frmMain()
        {
            InitializeComponent();
            rsc = new RibbonSupportClass(this);
           
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ss = SaveSender.AddBook;
            rpgBookModifier.Enabled = false;
            ClearPanel();
            addBookInfo info = new addBookInfo();
            info.Dock = DockStyle.Fill;
            info.btnMultiAuthor.Checked = false;
            scMain.SplitterPosition = info.Size.Width;
            scMain.Panel1.Controls.Add(info);
            scMain.Panel1.Enabled = true;
            addBookAuthor auth = new addBookAuthor();
            auth.Dock = DockStyle.Fill;
            auth.Size = scMain.Size;
            scMain.Panel2.Controls.Add(auth);
            scMain.Panel2.Enabled = false;
            ClearCheckDoCheck(btnAddBooks);
        }

        private void btnSaveBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ss != SaveSender.None)
                rsc.SaveNow(ss);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (userLoggedIn == null)
            {
                ribTabs.Visible = false;
                frmLogin log = new frmLogin();
                log.ShowDialog();
            }
        }

        private void tmDesigner_Tick(object sender, EventArgs e)
        {
            if (triggerDesigner)
            {
                ribTabs.Visible = true;
                if (userLoggedIn.Equals("Guest"))
                {
                    ribBooks.Visible = false;
                    ribBorrowing.Visible = false;
                    ribManageAccounts.Visible = false;
                    ribBorrower.Visible = true;
                }
                else if (userLoggedIn.Equals("1"))
                {
                    ribBooks.Visible = false;
                    ribBorrowing.Visible = false;
                    ribManageAccounts.Visible = true;
                    ribBorrower.Visible = false;
                }
                else
                {
                    ribBooks.Visible = true;
                    ribBorrowing.Visible = true;
                    ribManageAccounts.Visible = false;
                    ribBorrower.Visible = false;
                }
                triggerDesigner = false;
            }
        }
        private void ClearPanel()
        {
            scMain.Panel1.Controls.Clear();
            scMain.Panel2.Controls.Clear();
        }

        private void btnSaveAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ss != SaveSender.None)
            {
                rsc.SaveNow(ss);
                ((viewUsers)scMain.Panel2.Controls[0]).LoadList();
            }
        }

        private void btnAddAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.AddUser;
            addUser au = new addUser();
            au.Dock = DockStyle.Fill;
            scMain.SplitterPosition = au.Size.Width;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(au);

            viewUsers vu = new viewUsers(ss);
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnAddAccount);
        }

        private void btnUpdateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.UpdateUser;
            viewUsers vu = new viewUsers(ss);
            scMain.SplitterPosition = 0;
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnUpdateAccount);
        }

        private void btnResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.ResetPassword;
            viewUsers vu = new viewUsers(ss);
            scMain.SplitterPosition = 0;
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnResetPassword);
        }

        private void btnViewAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.None;
            viewUsers vu = new viewUsers(ss);
            scMain.SplitterPosition = 0;
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnViewAccount);
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            userLoggedIn = null;
            ribTabs.Visible = false;
            ClearPanel();
            frmLogin log = new frmLogin();
            log.ShowDialog();
        }

        private void ribTabs_SelectedPageChanged(object sender, EventArgs e)
        {
            ss = SaveSender.None;
            ClearPanel();
        }

        private void btnEditSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.EditSubject;
            subjectManage sm = new subjectManage(ss);
            scMain.SplitterPosition = sm.Size.Width;
            sm.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(sm);
            ClearCheckDoCheck(btnEditSubject);
        }

        private void btnDeleteSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.DeleteSubject;
            subjectManage sm = new subjectManage(ss);
            scMain.SplitterPosition = sm.Size.Width;
            sm.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(sm);
            ClearCheckDoCheck(btnDeleteSubjects);
        }
        private void ClearCheckDoCheck(BarCheckItem itm)
        {
            foreach (BarItem c in ribTabs.Items)
            {
                if (c is BarCheckItem)
                {
                    ((BarCheckItem)c).Checked = false;
                }
            }
            itm.Checked = true;
        }
    }
}
