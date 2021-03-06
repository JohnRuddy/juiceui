﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Juice.Framework;

namespace Juice_Sample_Site {
	public partial class Button : System.Web.UI.Page {

		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);

			CssManager.CssResourceMapping.AddDefinition("juice-ui", new CssResourceDefinition {
				Path = "~/Content/themes/Supercharged/jquery-ui-1.8.18.custom.css",
				DebugPath = "~/Content/themes/Supercharged/jquery-ui-1.8.18.custom.css"
			});

			_Postback.Click += delegate(object s, EventArgs ea) {
				var o = _JuiceButton.Disabled;
			};
		}

	}
}