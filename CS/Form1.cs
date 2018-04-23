using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace WindowsApplication41
{
	public class Form1 : System.Windows.Forms.Form
	{

	#region  Windows Form Designer generated code 

		public Form1() : base()
		{

			//This call is required by the Windows Form Designer.
			InitializeComponent();

			//Add any initialization after the InitializeComponent() call

		}

		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraEditors.TextEdit TextEdit1;
		internal DevExpress.XtraBars.Bar Bar1;
		internal DevExpress.XtraBars.BarEditItem BarEditItem1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepositoryItemCheckEdit1;
		internal DevExpress.XtraBars.BarEditItem BarEditItem2;
		internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
        private BarCheckItem barCheckItem1;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem1;
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.BarEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.BarEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar1});
            this.BarManager1.DockControls.Add(this.barDockControlTop);
            this.BarManager1.DockControls.Add(this.barDockControlBottom);
            this.BarManager1.DockControls.Add(this.barDockControlLeft);
            this.BarManager1.DockControls.Add(this.barDockControlRight);
            this.BarManager1.Form = this;
            this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarEditItem1,
            this.BarEditItem2,
            this.BarButtonItem1,
            this.barCheckItem1});
            this.BarManager1.MaxItemId = 4;
            this.BarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemCheckEdit1,
            this.RepositoryItemTextEdit1});
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Custom 1";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.BarEditItem2, "", false, true, true, 135),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1)});
            this.Bar1.Text = "Custom 1";
            // 
            // BarEditItem1
            // 
            this.BarEditItem1.Caption = "BarEditItem1";
            this.BarEditItem1.Edit = this.RepositoryItemCheckEdit1;
            this.BarEditItem1.Id = 0;
            this.BarEditItem1.Name = "BarEditItem1";
            this.BarEditItem1.EditValueChanged += new System.EventHandler(this.OnBarEditItemValueChanged);
            // 
            // RepositoryItemCheckEdit1
            // 
            this.RepositoryItemCheckEdit1.AutoHeight = false;
            this.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1";
            // 
            // BarEditItem2
            // 
            this.BarEditItem2.Caption = "BarEditItem2";
            this.BarEditItem2.Edit = this.RepositoryItemTextEdit1;
            this.BarEditItem2.Id = 1;
            this.BarEditItem2.Name = "BarEditItem2";
            this.BarEditItem2.EditValueChanged += new System.EventHandler(this.OnBarEditItemValueChanged);
            // 
            // RepositoryItemTextEdit1
            // 
            this.RepositoryItemTextEdit1.AutoHeight = false;
            this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
            // 
            // BarButtonItem1
            // 
            this.BarButtonItem1.Caption = "BarButtonItem1";
            this.BarButtonItem1.Id = 2;
            this.BarButtonItem1.Name = "BarButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "SaveImmediately";
            this.barCheckItem1.Id = 3;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(472, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 261);
            this.barDockControlBottom.Size = new System.Drawing.Size(472, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 232);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(472, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 232);
            // 
            // TextEdit1
            // 
            this.TextEdit1.EditValue = "TextEdit1";
            this.TextEdit1.Location = new System.Drawing.Point(27, 76);
            this.TextEdit1.Name = "TextEdit1";
            this.TextEdit1.Size = new System.Drawing.Size(173, 20);
            this.TextEdit1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.TextEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "How to save an in-place editor\'s value to a BarEditItem immediately when it\'s cha" +
                "nged";
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}

	#endregion

        BarManagerHelper helper;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            helper = new BarManagerHelper(BarManager1);
        }


        private void OnBarEditItemValueChanged(object sender, EventArgs e)
        {
            BarEditItem item = sender as BarEditItem;
            object val = item.EditValue;
            string txt = string.Empty;
            if (val != null)
                txt = val.ToString();
            XtraMessageBox.Show(txt);
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            helper.SaveEditValueImmediately = barCheckItem1.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.SaveEditValueImmediately = false;
        }


        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

     
	}

} //end of root namespace