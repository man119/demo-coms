﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave.Layout
{
    public partial class frmLeaveTypeLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveTypeLayout()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lblTypeName = new Smobiler.Core.Controls.Label();
            this.Image1 = new Smobiler.Core.Controls.Image();
            // 
            // lblTypeName
            // 
            this.lblTypeName.DataMember = "L_TYPE";
            this.lblTypeName.DisplayMember = "L_TYPEDESC";
            this.lblTypeName.FontSize = 7F;
            this.lblTypeName.Location = new Smobiler.Core.PointS(16F, 0F);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.SizeF(104F, 20F);
            this.lblTypeName.TabIndex = 3;
            // 
            // Image1
            // 
            this.Image1.DataMember = "L_TYPE";
            this.Image1.DisplayMember = "L_TYPE";
            this.Image1.ID = "";
            this.Image1.Location = new Smobiler.Core.PointS(3F, 5F);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.SizeF(10F, 10F);
            this.Image1.TabIndex = 5;
            // 
            // frmLeaveTypeLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTypeName,
            this.Image1});
            this.Size = new System.Drawing.Size(120, 20);
            this.Name = "frmLeaveTypeLayout";

        }
        internal Smobiler.Core.Controls.Label lblTypeName;

        internal Smobiler.Core.Controls.Image Image1;
        #endregion

    }
}