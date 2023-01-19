
namespace Team2_Project
{
    partial class frmUserCode
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            this.pnlSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.Size = new System.Drawing.Size(121, 24);
            // 
            // lblSearchName
            // 
            this.lblSearchName.Size = new System.Drawing.Size(138, 17);
            this.lblSearchName.Text = "사용자정의 대분류명";
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Size = new System.Drawing.Size(152, 17);
            this.lblSearchCode.Text = "사용자정의 대분류코드";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.Text = "사용자정의 상세분류명";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.Size = new System.Drawing.Size(166, 17);
            this.lblInfoNameMa.Text = "사용자정의 상세분류코드";
            // 
            // label11
            // 
            this.label11.Size = new System.Drawing.Size(138, 17);
            this.label11.Text = "사용자정의 대분류명";
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.Size = new System.Drawing.Size(152, 17);
            this.lblInfoCodeMa.Text = "사용자정의 대분류코드";
            // 
            // frmUserCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1318, 704);
            this.Name = "frmUserCode";
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}