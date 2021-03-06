﻿using Core;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Site
{
    public partial class SiteMaster : MasterPage
    {
        protected SitePage SitePage
        {
            get { return this.Page as SitePage; }
        }

        protected string JSPath
        {
            get
            {
                return HttpContext.Current.IsDebuggingEnabled ? "" : "min";
            }
        }

        public string Position
        {
            get
            {
                var e = this.SitePage.CurrentUser.Employees.FirstOrDefault();
                return e == null ? String.Empty : e.Position;
            }
        }

        public string AcademicDegree
        {
            get
            {
                var e = this.SitePage.CurrentUser.Employees.FirstOrDefault();
                return e == null ? String.Empty : e.AcademicDegree;
            }
        }

        public string UserPhoto
        {

            get { return this.SitePage.CurrentUser.Photo; }
        }

        public string UserFullName
        {
            get { return this.SitePage.CurrentUser.FullName; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                UserName.Text = SitePage.CurrentUser.FullName;

                var hiddenField = new HtmlGenericControl("input");
                hiddenField.Attributes.Add("id", "uhidden");
                hiddenField.Attributes.Add("type", "hidden");
                hiddenField.Attributes.Add("value", SitePage.CurrentUser.UserAccountId.ToString());

                form.Controls.Add(hiddenField);

                var hiddenField1 = new HtmlGenericControl("input");
                hiddenField1.Attributes.Add("id", "sssid");
                hiddenField1.Attributes.Add("type", "hidden");
                hiddenField1.Attributes.Add("value", SitePage.SessionId);

                form.Controls.Add(hiddenField1);

                CampusSessionId.Value = (this.Page as SitePage).SessionId;

                // individual_plan.Visible = SitePage.CurrentUser.Employees.Any(o => o.Position.Contains("Викладач"));
            }
            catch
            {
                UserName.Text = "Ошибка при загрузке страницы!!!";
            }
        }
    }
}