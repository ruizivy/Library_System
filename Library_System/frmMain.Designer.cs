﻿namespace Library_System
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribTabs = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveBooks = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelChanges = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiveReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnBorrowSelectedBook = new DevExpress.XtraBars.BarButtonItem();
            this.ribBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBookManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBookModifier = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSubject = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAuthor = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPublisher = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBorrowing = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgManaging = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBorrowingTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgReceiveTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPenalty = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribManageAccounts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgManageAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAccountTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBorrower = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBorrowerAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBorrowControl = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.scMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.tmDesigner = new System.Windows.Forms.Timer(this.components);
            this.btnAddBooks = new DevExpress.XtraBars.BarCheckItem();
            this.btnViewSearch = new DevExpress.XtraBars.BarCheckItem();
            this.btnEditBook = new DevExpress.XtraBars.BarCheckItem();
            this.btnDeleteBooks = new DevExpress.XtraBars.BarCheckItem();
            this.btnEditSubject = new DevExpress.XtraBars.BarCheckItem();
            this.btnDeleteSubjects = new DevExpress.XtraBars.BarCheckItem();
            this.btnCheckRequest = new DevExpress.XtraBars.BarCheckItem();
            this.btnReceiveReturns = new DevExpress.XtraBars.BarCheckItem();
            this.btnApproveRequest = new DevExpress.XtraBars.BarButtonItem();
            this.btnRejectRequest = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckPenalties = new DevExpress.XtraBars.BarCheckItem();
            this.btnCheckPenaltyStatistics = new DevExpress.XtraBars.BarCheckItem();
            this.btnAddAccount = new DevExpress.XtraBars.BarCheckItem();
            this.btnUpdateAccount = new DevExpress.XtraBars.BarCheckItem();
            this.btnResetPassword = new DevExpress.XtraBars.BarCheckItem();
            this.btnViewAccount = new DevExpress.XtraBars.BarCheckItem();
            this.btnRegisterBorrower = new DevExpress.XtraBars.BarCheckItem();
            this.btnSearchBorrowBook = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribTabs
            // 
            this.ribTabs.ApplicationButtonDropDownControl = this.appMenu;
            this.ribTabs.ExpandCollapseItem.Id = 0;
            this.ribTabs.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribTabs.ExpandCollapseItem,
            this.btnSaveBook,
            this.btnSaveBooks,
            this.btnCancelChanges,
            this.btnReceiveReturn,
            this.btnSaveAccount,
            this.btnBorrowSelectedBook,
            this.btnLogout,
            this.btnAddBooks,
            this.btnViewSearch,
            this.btnEditBook,
            this.btnDeleteBooks,
            this.btnEditSubject,
            this.btnDeleteSubjects,
            this.btnCheckRequest,
            this.btnReceiveReturns,
            this.btnApproveRequest,
            this.btnRejectRequest,
            this.btnCheckPenalties,
            this.btnCheckPenaltyStatistics,
            this.btnAddAccount,
            this.btnUpdateAccount,
            this.btnResetPassword,
            this.btnViewAccount,
            this.btnRegisterBorrower,
            this.btnSearchBorrowBook});
            this.ribTabs.Location = new System.Drawing.Point(0, 0);
            this.ribTabs.MaxItemId = 27;
            this.ribTabs.Name = "ribTabs";
            this.ribTabs.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribBooks,
            this.ribBorrowing,
            this.ribManageAccounts,
            this.ribBorrower});
            this.ribTabs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribTabs.ShowToolbarCustomizeItem = false;
            this.ribTabs.Size = new System.Drawing.Size(919, 143);
            this.ribTabs.Toolbar.ShowCustomizeItem = false;
            this.ribTabs.SelectedPageChanged += new System.EventHandler(this.ribTabs_SelectedPageChanged);
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.btnLogout);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribTabs;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Id = 2;
            this.btnLogout.ImageUri.Uri = "Show";
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Caption = "Save";
            this.btnSaveBook.Id = 6;
            this.btnSaveBook.ImageUri.Uri = "Save";
            this.btnSaveBook.Name = "btnSaveBook";
            // 
            // btnSaveBooks
            // 
            this.btnSaveBooks.Caption = "Save";
            this.btnSaveBooks.Id = 10;
            this.btnSaveBooks.ImageUri.Uri = "Save";
            this.btnSaveBooks.Name = "btnSaveBooks";
            this.btnSaveBooks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveBooks_ItemClick);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Caption = "Cancel Changes";
            this.btnCancelChanges.Id = 13;
            this.btnCancelChanges.ImageUri.Uri = "SaveAndClose";
            this.btnCancelChanges.Name = "btnCancelChanges";
            // 
            // btnReceiveReturn
            // 
            this.btnReceiveReturn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnReceiveReturn.Caption = "Receive Selected";
            this.btnReceiveReturn.Id = 21;
            this.btnReceiveReturn.ImageUri.Uri = "Squeeze";
            this.btnReceiveReturn.Name = "btnReceiveReturn";
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Caption = "Save";
            this.btnSaveAccount.Id = 25;
            this.btnSaveAccount.ImageUri.Uri = "Save";
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAccount_ItemClick);
            // 
            // btnBorrowSelectedBook
            // 
            this.btnBorrowSelectedBook.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnBorrowSelectedBook.Caption = "Borrow Selected Book";
            this.btnBorrowSelectedBook.Id = 30;
            this.btnBorrowSelectedBook.ImageUri.Uri = "Up";
            this.btnBorrowSelectedBook.Name = "btnBorrowSelectedBook";
            // 
            // ribBooks
            // 
            this.ribBooks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBookManager,
            this.rpgBookModifier,
            this.rpgSubject,
            this.rpgAuthor,
            this.rpgPublisher,
            this.rpgTools});
            this.ribBooks.Name = "ribBooks";
            this.ribBooks.Text = "Manage Books";
            // 
            // rpgBookManager
            // 
            this.rpgBookManager.ItemLinks.Add(this.btnAddBooks);
            this.rpgBookManager.ItemLinks.Add(this.btnViewSearch);
            this.rpgBookManager.Name = "rpgBookManager";
            this.rpgBookManager.Text = "Book Manager";
            // 
            // rpgBookModifier
            // 
            this.rpgBookModifier.ItemLinks.Add(this.btnEditBook);
            this.rpgBookModifier.ItemLinks.Add(this.btnDeleteBooks);
            this.rpgBookModifier.Name = "rpgBookModifier";
            this.rpgBookModifier.Text = "Book Modifier";
            // 
            // rpgSubject
            // 
            this.rpgSubject.ItemLinks.Add(this.btnEditSubject);
            this.rpgSubject.ItemLinks.Add(this.btnDeleteSubjects);
            this.rpgSubject.Name = "rpgSubject";
            this.rpgSubject.Text = "Subject";
            // 
            // rpgAuthor
            // 
            this.rpgAuthor.Name = "rpgAuthor";
            this.rpgAuthor.Text = "Author";
            // 
            // rpgPublisher
            // 
            this.rpgPublisher.Name = "rpgPublisher";
            this.rpgPublisher.Text = "Publisher";
            // 
            // rpgTools
            // 
            this.rpgTools.ItemLinks.Add(this.btnSaveBooks);
            this.rpgTools.ItemLinks.Add(this.btnCancelChanges);
            this.rpgTools.Name = "rpgTools";
            this.rpgTools.Text = "Book Tools";
            // 
            // ribBorrowing
            // 
            this.ribBorrowing.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgManaging,
            this.rpgBorrowingTools,
            this.rpgReceiveTools,
            this.rpgPenalty});
            this.ribBorrowing.Name = "ribBorrowing";
            this.ribBorrowing.Text = "Borrowing Options";
            // 
            // rpgManaging
            // 
            this.rpgManaging.ItemLinks.Add(this.btnCheckRequest);
            this.rpgManaging.ItemLinks.Add(this.btnReceiveReturns);
            this.rpgManaging.Name = "rpgManaging";
            this.rpgManaging.Text = "Manage In/Out";
            // 
            // rpgBorrowingTools
            // 
            this.rpgBorrowingTools.ItemLinks.Add(this.btnApproveRequest);
            this.rpgBorrowingTools.ItemLinks.Add(this.btnRejectRequest);
            this.rpgBorrowingTools.Name = "rpgBorrowingTools";
            this.rpgBorrowingTools.Text = "Borrowing Tools";
            // 
            // rpgReceiveTools
            // 
            this.rpgReceiveTools.AllowTextClipping = false;
            this.rpgReceiveTools.ItemLinks.Add(this.btnReceiveReturn);
            this.rpgReceiveTools.Name = "rpgReceiveTools";
            this.rpgReceiveTools.Text = "Receiving Tools";
            // 
            // rpgPenalty
            // 
            this.rpgPenalty.ItemLinks.Add(this.btnCheckPenalties);
            this.rpgPenalty.ItemLinks.Add(this.btnCheckPenaltyStatistics);
            this.rpgPenalty.Name = "rpgPenalty";
            this.rpgPenalty.Text = "Penalties";
            // 
            // ribManageAccounts
            // 
            this.ribManageAccounts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgManageAccount,
            this.rpgAccountTools});
            this.ribManageAccounts.Name = "ribManageAccounts";
            this.ribManageAccounts.Text = "Manage Accounts";
            // 
            // rpgManageAccount
            // 
            this.rpgManageAccount.ItemLinks.Add(this.btnAddAccount);
            this.rpgManageAccount.ItemLinks.Add(this.btnUpdateAccount);
            this.rpgManageAccount.ItemLinks.Add(this.btnResetPassword);
            this.rpgManageAccount.Name = "rpgManageAccount";
            this.rpgManageAccount.Text = "Manage Account";
            // 
            // rpgAccountTools
            // 
            this.rpgAccountTools.ItemLinks.Add(this.btnSaveAccount);
            this.rpgAccountTools.ItemLinks.Add(this.btnViewAccount);
            this.rpgAccountTools.Name = "rpgAccountTools";
            this.rpgAccountTools.Text = "Tools";
            // 
            // ribBorrower
            // 
            this.ribBorrower.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBorrowerAccount,
            this.rpgBorrowControl});
            this.ribBorrower.Name = "ribBorrower";
            this.ribBorrower.Text = "Borrower\'s Menu";
            // 
            // rpgBorrowerAccount
            // 
            this.rpgBorrowerAccount.AllowTextClipping = false;
            this.rpgBorrowerAccount.ItemLinks.Add(this.btnRegisterBorrower);
            this.rpgBorrowerAccount.Name = "rpgBorrowerAccount";
            this.rpgBorrowerAccount.Text = "Accounts";
            // 
            // rpgBorrowControl
            // 
            this.rpgBorrowControl.ItemLinks.Add(this.btnSearchBorrowBook);
            this.rpgBorrowControl.ItemLinks.Add(this.btnBorrowSelectedBook);
            this.rpgBorrowControl.Name = "rpgBorrowControl";
            this.rpgBorrowControl.Text = "Borrow Control";
            // 
            // scMain
            // 
            this.scMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 143);
            this.scMain.Name = "scMain";
            this.scMain.Panel1.Text = "Panel1";
            this.scMain.Panel2.AutoScroll = true;
            this.scMain.Panel2.Text = "Panel2";
            this.scMain.Size = new System.Drawing.Size(919, 328);
            this.scMain.SplitterPosition = 438;
            this.scMain.TabIndex = 1;
            this.scMain.Text = "splitContainerControl1";
            // 
            // tmDesigner
            // 
            this.tmDesigner.Enabled = true;
            this.tmDesigner.Tick += new System.EventHandler(this.tmDesigner_Tick);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Caption = "Add Book";
            this.btnAddBooks.Id = 7;
            this.btnAddBooks.ImageUri.Uri = "AddItem";
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnViewSearch
            // 
            this.btnViewSearch.Caption = "View/Search Books";
            this.btnViewSearch.Id = 9;
            this.btnViewSearch.ImageUri.Uri = "Zoom";
            this.btnViewSearch.Name = "btnViewSearch";
            // 
            // btnEditBook
            // 
            this.btnEditBook.Caption = "Edit Book";
            this.btnEditBook.Id = 10;
            this.btnEditBook.ImageUri.Uri = "Edit";
            this.btnEditBook.Name = "btnEditBook";
            // 
            // btnDeleteBooks
            // 
            this.btnDeleteBooks.Caption = "Delete Book(s)";
            this.btnDeleteBooks.Id = 11;
            this.btnDeleteBooks.ImageUri.Uri = "Delete";
            this.btnDeleteBooks.Name = "btnDeleteBooks";
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.Caption = "Edit Subject";
            this.btnEditSubject.Id = 12;
            this.btnEditSubject.ImageUri.Uri = "Strikeout";
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditSubject_ItemClick);
            // 
            // btnDeleteSubjects
            // 
            this.btnDeleteSubjects.Caption = "Delete Subject(s)";
            this.btnDeleteSubjects.Id = 13;
            this.btnDeleteSubjects.ImageUri.Uri = "StrikeoutDouble";
            this.btnDeleteSubjects.Name = "btnDeleteSubjects";
            this.btnDeleteSubjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteSubject_ItemClick);
            // 
            // btnCheckRequest
            // 
            this.btnCheckRequest.Caption = "Check Borrow Request";
            this.btnCheckRequest.Id = 14;
            this.btnCheckRequest.ImageUri.Uri = "Apply";
            this.btnCheckRequest.Name = "btnCheckRequest";
            // 
            // btnReceiveReturns
            // 
            this.btnReceiveReturns.Caption = "Receive Returns";
            this.btnReceiveReturns.Id = 15;
            this.btnReceiveReturns.ImageUri.Uri = "Reset";
            this.btnReceiveReturns.Name = "btnReceiveReturns";
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.Caption = "Approve Request";
            this.btnApproveRequest.Id = 17;
            this.btnApproveRequest.ImageUri.Uri = "Previous";
            this.btnApproveRequest.Name = "btnApproveRequest";
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.Caption = "Reject Request";
            this.btnRejectRequest.Id = 18;
            this.btnRejectRequest.ImageUri.Uri = "Cancel";
            this.btnRejectRequest.Name = "btnRejectRequest";
            // 
            // btnCheckPenalties
            // 
            this.btnCheckPenalties.Caption = "Check Penalties";
            this.btnCheckPenalties.Id = 19;
            this.btnCheckPenalties.ImageUri.Uri = "AlignJustify";
            this.btnCheckPenalties.Name = "btnCheckPenalties";
            // 
            // btnCheckPenaltyStatistics
            // 
            this.btnCheckPenaltyStatistics.Caption = "Check Penalty Statistics";
            this.btnCheckPenaltyStatistics.Id = 20;
            this.btnCheckPenaltyStatistics.ImageUri.Uri = "Chart";
            this.btnCheckPenaltyStatistics.Name = "btnCheckPenaltyStatistics";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Caption = "Add Account";
            this.btnAddAccount.Id = 21;
            this.btnAddAccount.ImageUri.Uri = "Add";
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddAccount_ItemClick);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Caption = "Update Account";
            this.btnUpdateAccount.Id = 22;
            this.btnUpdateAccount.ImageUri.Uri = "Edit";
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateAccount_ItemClick);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Caption = "Reset Account Password";
            this.btnResetPassword.Id = 23;
            this.btnResetPassword.ImageUri.Uri = "Cut";
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetPassword_ItemClick);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Caption = "View Account";
            this.btnViewAccount.Id = 24;
            this.btnViewAccount.ImageUri.Uri = "Find";
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewAccounts_ItemClick);
            // 
            // btnRegisterBorrower
            // 
            this.btnRegisterBorrower.Caption = "Register";
            this.btnRegisterBorrower.Id = 25;
            this.btnRegisterBorrower.ImageUri.Uri = "AddNewDataSource";
            this.btnRegisterBorrower.Name = "btnRegisterBorrower";
            // 
            // btnSearchBorrowBook
            // 
            this.btnSearchBorrowBook.Caption = "Search Books";
            this.btnSearchBorrowBook.Id = 26;
            this.btnSearchBorrowBook.ImageUri.Uri = "Zoom";
            this.btnSearchBorrowBook.Name = "btnSearchBorrowBook";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 471);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ribTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Ribbon = this.ribTabs;
            this.Text = "Library System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribTabs;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBooks;
        private DevExpress.XtraBars.BarButtonItem btnSaveBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBookManager;
        private DevExpress.XtraBars.BarButtonItem btnSaveBooks;
        private DevExpress.XtraBars.BarButtonItem btnCancelChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSubject;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBorrowing;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgManaging;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPenalty;
        private DevExpress.XtraBars.BarButtonItem btnReceiveReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBorrowingTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReceiveTools;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribManageAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgManageAccount;
        private DevExpress.XtraBars.BarButtonItem btnSaveAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAccountTools;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBorrower;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBorrowerAccount;
        private DevExpress.XtraBars.BarButtonItem btnBorrowSelectedBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBorrowControl;
        private System.Windows.Forms.Timer tmDesigner;
        public DevExpress.XtraEditors.SplitContainerControl scMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBookModifier;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAuthor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPublisher;
        private DevExpress.XtraBars.BarCheckItem btnAddBooks;
        private DevExpress.XtraBars.BarCheckItem btnViewSearch;
        private DevExpress.XtraBars.BarCheckItem btnEditBook;
        private DevExpress.XtraBars.BarCheckItem btnDeleteBooks;
        private DevExpress.XtraBars.BarCheckItem btnEditSubject;
        private DevExpress.XtraBars.BarCheckItem btnDeleteSubjects;
        private DevExpress.XtraBars.BarCheckItem btnCheckRequest;
        private DevExpress.XtraBars.BarCheckItem btnReceiveReturns;
        private DevExpress.XtraBars.BarButtonItem btnApproveRequest;
        private DevExpress.XtraBars.BarButtonItem btnRejectRequest;
        private DevExpress.XtraBars.BarCheckItem btnCheckPenalties;
        private DevExpress.XtraBars.BarCheckItem btnCheckPenaltyStatistics;
        private DevExpress.XtraBars.BarCheckItem btnAddAccount;
        private DevExpress.XtraBars.BarCheckItem btnUpdateAccount;
        private DevExpress.XtraBars.BarCheckItem btnResetPassword;
        private DevExpress.XtraBars.BarCheckItem btnViewAccount;
        private DevExpress.XtraBars.BarCheckItem btnRegisterBorrower;
        private DevExpress.XtraBars.BarCheckItem btnSearchBorrowBook;
    }
}

