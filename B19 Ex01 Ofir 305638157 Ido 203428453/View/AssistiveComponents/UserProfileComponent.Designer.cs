﻿using System.Windows.Forms;

namespace View
{
    partial class UserProfileComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_ComponentBindingSourceFeed = new System.Windows.Forms.BindingSource(this.components);
            this.m_ComponentDataGridViewUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkToFacebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ComponentBindingSourceUpcomingEvents = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_ComponentButtonPostOnWall = new System.Windows.Forms.Button();
            this.m_ComponentTextBoxPostOnWall = new System.Windows.Forms.TextBox();
            this.m_ComponentTextBoxUserInfo = new System.Windows.Forms.TextBox();
            this.m_ComponentPictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentDataGridViewUpcomingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceUpcomingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentPictureBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ComponentBindingSourceFeed
            // 
            this.m_ComponentBindingSourceFeed.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // m_ComponentDataGridViewUpcomingEvents
            // 
            this.m_ComponentDataGridViewUpcomingEvents.AllowUserToAddRows = false;
            this.m_ComponentDataGridViewUpcomingEvents.AllowUserToDeleteRows = false;
            this.m_ComponentDataGridViewUpcomingEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ComponentDataGridViewUpcomingEvents.AutoGenerateColumns = false;
            this.m_ComponentDataGridViewUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_ComponentDataGridViewUpcomingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.linkToFacebookDataGridViewTextBoxColumn,
            this.timeStringDataGridViewTextBoxColumn});
            this.m_ComponentDataGridViewUpcomingEvents.DataSource = this.m_ComponentBindingSourceUpcomingEvents;
            this.m_ComponentDataGridViewUpcomingEvents.Location = new System.Drawing.Point(310, 31);
            this.m_ComponentDataGridViewUpcomingEvents.Margin = new System.Windows.Forms.Padding(2);
            this.m_ComponentDataGridViewUpcomingEvents.Name = "m_ComponentDataGridViewUpcomingEvents";
            this.m_ComponentDataGridViewUpcomingEvents.ReadOnly = true;
            this.m_ComponentDataGridViewUpcomingEvents.RowTemplate.Height = 28;
            this.m_ComponentDataGridViewUpcomingEvents.Size = new System.Drawing.Size(547, 256);
            this.m_ComponentDataGridViewUpcomingEvents.TabIndex = 17;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkToFacebookDataGridViewTextBoxColumn
            // 
            this.linkToFacebookDataGridViewTextBoxColumn.DataPropertyName = "LinkToFacebook";
            this.linkToFacebookDataGridViewTextBoxColumn.HeaderText = "Link To Facebook";
            this.linkToFacebookDataGridViewTextBoxColumn.Name = "linkToFacebookDataGridViewTextBoxColumn";
            this.linkToFacebookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStringDataGridViewTextBoxColumn
            // 
            this.timeStringDataGridViewTextBoxColumn.DataPropertyName = "TimeString";
            this.timeStringDataGridViewTextBoxColumn.HeaderText = "TimeString";
            this.timeStringDataGridViewTextBoxColumn.Name = "timeStringDataGridViewTextBoxColumn";
            this.timeStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // m_ComponentBindingSourceUpcomingEvents
            // 
            this.m_ComponentBindingSourceUpcomingEvents.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(307, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Upcoming Events:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(13, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Basic Information:";
            // 
            // m_ComponentButtonPostOnWall
            // 
            this.m_ComponentButtonPostOnWall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ComponentButtonPostOnWall.BackColor = System.Drawing.Color.DarkBlue;
            this.m_ComponentButtonPostOnWall.ForeColor = System.Drawing.Color.White;
            this.m_ComponentButtonPostOnWall.Location = new System.Drawing.Point(415, 466);
            this.m_ComponentButtonPostOnWall.Margin = new System.Windows.Forms.Padding(2);
            this.m_ComponentButtonPostOnWall.Name = "m_ComponentButtonPostOnWall";
            this.m_ComponentButtonPostOnWall.Size = new System.Drawing.Size(251, 31);
            this.m_ComponentButtonPostOnWall.TabIndex = 13;
            this.m_ComponentButtonPostOnWall.Text = "Post";
            this.m_ComponentButtonPostOnWall.UseVisualStyleBackColor = false;
            this.m_ComponentButtonPostOnWall.Click += new System.EventHandler(this.m_ComponentButtonPostOnWall_Click);
            // 
            // m_ComponentTextBoxPostOnWall
            // 
            this.m_ComponentTextBoxPostOnWall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ComponentTextBoxPostOnWall.BackColor = System.Drawing.Color.AliceBlue;
            this.m_ComponentTextBoxPostOnWall.Location = new System.Drawing.Point(310, 323);
            this.m_ComponentTextBoxPostOnWall.Margin = new System.Windows.Forms.Padding(2);
            this.m_ComponentTextBoxPostOnWall.Multiline = true;
            this.m_ComponentTextBoxPostOnWall.Name = "m_ComponentTextBoxPostOnWall";
            this.m_ComponentTextBoxPostOnWall.Size = new System.Drawing.Size(455, 129);
            this.m_ComponentTextBoxPostOnWall.TabIndex = 12;
            this.m_ComponentTextBoxPostOnWall.Tag = "Do you want to say anything?";
            this.m_ComponentTextBoxPostOnWall.Text = "Do you want to say anything?";
            this.m_ComponentTextBoxPostOnWall.Click += new System.EventHandler(this.m_ComponentTextBoxPostOnWall_Click);
            // 
            // m_ComponentTextBoxUserInfo
            // 
            this.m_ComponentTextBoxUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ComponentTextBoxUserInfo.Location = new System.Drawing.Point(16, 279);
            this.m_ComponentTextBoxUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.m_ComponentTextBoxUserInfo.Multiline = true;
            this.m_ComponentTextBoxUserInfo.Name = "m_ComponentTextBoxUserInfo";
            this.m_ComponentTextBoxUserInfo.ReadOnly = true;
            this.m_ComponentTextBoxUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_ComponentTextBoxUserInfo.Size = new System.Drawing.Size(186, 239);
            this.m_ComponentTextBoxUserInfo.TabIndex = 11;
            this.m_ComponentTextBoxUserInfo.Text = "User info to show]";
            // 
            // m_ComponentPictureBoxProfilePic
            // 
            this.m_ComponentPictureBoxProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ComponentPictureBoxProfilePic.Location = new System.Drawing.Point(16, 31);
            this.m_ComponentPictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(2);
            this.m_ComponentPictureBoxProfilePic.Name = "m_ComponentPictureBoxProfilePic";
            this.m_ComponentPictureBoxProfilePic.Size = new System.Drawing.Size(239, 212);
            this.m_ComponentPictureBoxProfilePic.TabIndex = 10;
            this.m_ComponentPictureBoxProfilePic.TabStop = false;
            // 
            // UserProfileComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_ComponentDataGridViewUpcomingEvents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_ComponentButtonPostOnWall);
            this.Controls.Add(this.m_ComponentTextBoxPostOnWall);
            this.Controls.Add(this.m_ComponentTextBoxUserInfo);
            this.Controls.Add(this.m_ComponentPictureBoxProfilePic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserProfileComponent";
            this.Size = new System.Drawing.Size(939, 574);
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentDataGridViewUpcomingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceUpcomingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentPictureBoxProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView m_ComponentDataGridViewUpcomingEvents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button m_ComponentButtonPostOnWall;
        private System.Windows.Forms.TextBox m_ComponentTextBoxPostOnWall;
        private System.Windows.Forms.TextBox m_ComponentTextBoxUserInfo;
        private System.Windows.Forms.PictureBox m_ComponentPictureBoxProfilePic;
        private System.Windows.Forms.BindingSource m_ComponentBindingSourceFeed;
        private System.Windows.Forms.BindingSource m_ComponentBindingSourceUpcomingEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToFacebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStringDataGridViewTextBoxColumn;
    }
}