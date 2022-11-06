using JSLibrary;
using Microsoft.AspNetCore.Mvc;
using ngJSApp.Database;
using ngJSApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ngJSApp.Controllers
{
    public partial class ModelController
    {
        //
        //
        //
        [HttpPost("GetTabs/{Oid_DetailView}")]
        public ActionResult GetTabs(string Oid_DetailView, PagingParams p)
        {
            string SQL = $"SELECT Oid, Name, Caption FROM _vDetailView_Detail WHERE ID_DetailView = '{Oid_DetailView}' AND ID_ControlType = 12";
            p.PrimaryKey = "Oid";
            p.SQL = SQL;
            var res = this.GetPagingResult(p);
            return Ok(res);
        }

        [HttpPost("GetSections/{Oid_DetailView}")]
        public ActionResult GetSections(string Oid_DetailView, PagingParams p)
        {
            string SQL = $"SELECT Oid, Name, Caption FROM _vDetailView_Detail WHERE ID_DetailView = '{Oid_DetailView}' AND ID_ControlType = 13";
            p.PrimaryKey = "Oid";
            p.SQL = SQL;
            var res = this.GetPagingResult(p);
            return Ok(res);
        }

        [HttpPost("DetailControl/{Oid}/{Oid_DetailView}/{IsRootOnly}")]
        public ActionResult GetDetailControls(string Oid, string Oid_DetailView, bool IsRootOnly, PagingParams p)
        {
            _vDetailView_Detail control = null;
            string SQL = null;
            if (IsRootOnly != true)
            {
                if (String.IsNullOrEmpty(Oid) != true && Oid != "-")
                {
                    control = this.ctx._vDetailView_Detail.SingleOrDefault(d => d.Oid.ToString() == Oid);
                    SQL = $"SELECT * FROM _vDetailView_Detail WHERE Oid = '{Oid}' ";
                }
                else
                {
                    SQL = $"SELECT * FROM _vDetailView_Detail WHERE ID_DetailView = '{Oid_DetailView}' ";
                }
            }
            else {
                SQL = $"SELECT * FROM _vDetailView_Detail WHERE ID_DetailView = '{Oid_DetailView}' AND ID_Tab IS NULL AND ID_Section IS NULL";
            }
            
            if (control != null)
            {
                switch (control.ID_ControlType)
                {
                    case 12: // Tab
                        SQL += $" OR ID_Tab = '{Oid}'";
                        break;
                    case 13: // Section
                        SQL += $" OR ID_Section = '{Oid}'";
                        break;
                }
            }
            p.PrimaryKey = "Oid";
            p.SQL = SQL;
            var res = this.GetPagingResult(p);
            return Ok(res);
        }

        [HttpPost("ListViewColumns/{Oid_ListView}/{Oid}")]
        public ActionResult GetListViewControls(string Oid_ListView, string Oid, PagingParams p)
        {
            string SQL = $"SELECT * FROM _vListView_Detail WHERE ID_ListView = '{Oid_ListView}' ";
            if (Oid != "-")
            {
                SQL += $" AND Oid = '{Oid}'";
            }
            p.PrimaryKey = "Oid";
            p.SQL = SQL;
            var res = this.GetPagingResult(p);
            return Ok(res);
        }
    }
} 