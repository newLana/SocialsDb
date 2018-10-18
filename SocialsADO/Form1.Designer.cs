namespace SocialsADO
{
    partial class Form1
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
            this.dgvPhoto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhotoLikes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLikesComment = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.btnDeletePhotoLike = new System.Windows.Forms.Button();
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.btnDeleteCommentLike = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhotoLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLikesComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhoto
            // 
            this.dgvPhoto.AllowUserToDeleteRows = false;
            this.dgvPhoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoto.Location = new System.Drawing.Point(16, 22);
            this.dgvPhoto.MultiSelect = false;
            this.dgvPhoto.Name = "dgvPhoto";
            this.dgvPhoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhoto.Size = new System.Drawing.Size(402, 336);
            this.dgvPhoto.TabIndex = 0;
            this.dgvPhoto.DataSourceChanged += new System.EventHandler(this.dgvPhoto_DataSourceChanged);
            this.dgvPhoto.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvPhoto_CellValidating);
            this.dgvPhoto.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPhoto_EditingControlShowing);
            this.dgvPhoto.SelectionChanged += new System.EventHandler(this.dgvPhoto_SelectionChanged);
            this.dgvPhoto.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPhoto_UserAddedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Photos";
            // 
            // dgvPhotoLikes
            // 
            this.dgvPhotoLikes.AllowUserToDeleteRows = false;
            this.dgvPhotoLikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhotoLikes.Location = new System.Drawing.Point(16, 380);
            this.dgvPhotoLikes.MultiSelect = false;
            this.dgvPhotoLikes.Name = "dgvPhotoLikes";
            this.dgvPhotoLikes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhotoLikes.Size = new System.Drawing.Size(276, 239);
            this.dgvPhotoLikes.TabIndex = 2;
            this.dgvPhotoLikes.DataSourceChanged += new System.EventHandler(this.dgvLikes_DataSourceChanged);
            this.dgvPhotoLikes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvLikes_CellValidating);
            this.dgvPhotoLikes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPhotoLikes_EditingControlShowing);
            this.dgvPhotoLikes.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPhotoLikes_UserAddedRow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Likes Photo";
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(448, 22);
            this.dgvComments.MultiSelect = false;
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.Size = new System.Drawing.Size(413, 331);
            this.dgvComments.TabIndex = 4;
            this.dgvComments.DataSourceChanged += new System.EventHandler(this.dgvComments_DataSourceChanged);
            this.dgvComments.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvComments_CellValidating);
            this.dgvComments.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvComments_EditingControlShowing);
            this.dgvComments.SelectionChanged += new System.EventHandler(this.dgvComments_SelectionChanged);
            this.dgvComments.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvComments_UserAddedRow);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comments";
            // 
            // dgvLikesComment
            // 
            this.dgvLikesComment.AllowUserToDeleteRows = false;
            this.dgvLikesComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLikesComment.Location = new System.Drawing.Point(548, 380);
            this.dgvLikesComment.MultiSelect = false;
            this.dgvLikesComment.Name = "dgvLikesComment";
            this.dgvLikesComment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLikesComment.Size = new System.Drawing.Size(313, 239);
            this.dgvLikesComment.TabIndex = 6;
            this.dgvLikesComment.DataSourceChanged += new System.EventHandler(this.dgvLikes_DataSourceChanged);
            this.dgvLikesComment.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvLikes_CellValidating);
            this.dgvLikesComment.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCommentLikes_EditingControlShowing);
            this.dgvLikesComment.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvLikesComment_UserAddedRow);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Likes Comment";
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.Location = new System.Drawing.Point(317, 380);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(101, 31);
            this.btnDeletePhoto.TabIndex = 8;
            this.btnDeletePhoto.Text = "Delete Photo";
            this.btnDeletePhoto.UseVisualStyleBackColor = true;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // btnDeletePhotoLike
            // 
            this.btnDeletePhotoLike.Location = new System.Drawing.Point(317, 430);
            this.btnDeletePhotoLike.Name = "btnDeletePhotoLike";
            this.btnDeletePhotoLike.Size = new System.Drawing.Size(101, 35);
            this.btnDeletePhotoLike.TabIndex = 9;
            this.btnDeletePhotoLike.Text = "Delete Like";
            this.btnDeletePhotoLike.UseVisualStyleBackColor = true;
            this.btnDeletePhotoLike.Click += new System.EventHandler(this.btnDeletePhotoLike_Click);
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.Location = new System.Drawing.Point(448, 380);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(94, 31);
            this.btnDeleteComment.TabIndex = 10;
            this.btnDeleteComment.Text = "Delete Comment";
            this.btnDeleteComment.UseVisualStyleBackColor = true;
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
            // 
            // btnDeleteCommentLike
            // 
            this.btnDeleteCommentLike.Location = new System.Drawing.Point(448, 430);
            this.btnDeleteCommentLike.Name = "btnDeleteCommentLike";
            this.btnDeleteCommentLike.Size = new System.Drawing.Size(94, 35);
            this.btnDeleteCommentLike.TabIndex = 11;
            this.btnDeleteCommentLike.Text = "Delete Like";
            this.btnDeleteCommentLike.UseVisualStyleBackColor = true;
            this.btnDeleteCommentLike.Click += new System.EventHandler(this.btnDeleteCommentLike_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(907, 22);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(305, 331);
            this.dgvUsers.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Users";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnDeleteCommentLike);
            this.Controls.Add(this.btnDeleteComment);
            this.Controls.Add(this.btnDeletePhotoLike);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLikesComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPhotoLikes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhotoLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLikesComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhotoLikes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLikesComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeletePhoto;
        private System.Windows.Forms.Button btnDeletePhotoLike;
        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.Button btnDeleteCommentLike;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label5;
    }
}

