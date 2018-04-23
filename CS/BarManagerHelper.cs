using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication41
{
    public class BarManagerHelper
    {
        BarManager manager;

        public BarManagerHelper(BarManager manager)
        {
            this.manager = manager;
        }

        public bool SaveEditValueImmediately
        {
            set
            {
                UnsubscribeFromEvents();
                if (value)
                    SubscribeToEvents();
            }
        }

        private void SubscribeToEvents()
        {
            foreach (RepositoryItem item in manager.RepositoryItems)
                item.EditValueChanged += OnEditValueChanged;
        }

        private void UnsubscribeFromEvents()
        {
            foreach (RepositoryItem item in manager.RepositoryItems)
                item.EditValueChanged -= OnEditValueChanged;
        }

        void OnEditValueChanged(object sender, EventArgs e)
        {
            manager.ActiveEditItemLink.PostEditor();
        }
    }
}
