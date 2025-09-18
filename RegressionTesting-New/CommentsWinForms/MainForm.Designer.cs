namespace CommentsWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(9, 11);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(80, 13);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Комментарий:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 27);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(181, 20);
            this.commentTextBox.TabIndex = 1;
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(12, 69);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(181, 21);
            this.userComboBox.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(9, 53);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(83, 13);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Пользователь:";
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(12, 96);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(181, 23);
            this.addCommentButton.TabIndex = 4;
            this.addCommentButton.Text = "Добавить комментарий";
            this.addCommentButton.UseVisualStyleBackColor = true;
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // commentsListBox
            // 
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(210, 12);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(199, 225);
            this.commentsListBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 247);
            this.Controls.Add(this.commentsListBox);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Name = "MainForm";
            this.Text = "Комментарии пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.ListBox commentsListBox;
    }
}

