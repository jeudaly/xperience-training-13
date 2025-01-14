﻿#define no_suffix

using Common.Configuration;

using MedioClinic.Customizations.Cookies;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedioClinic.Components.ViewComponents
{
    public class ExternalAnalyticalTools : ViewComponent
    {
        private readonly IOptionsMonitor<XperienceOptions> _optionsMonitor;

        private readonly ICookieManager _cookieManager;

        public ExternalAnalyticalTools(IOptionsMonitor<XperienceOptions> optionsMonitor, ICookieManager cookieManager)
        {
            _optionsMonitor = optionsMonitor ?? throw new ArgumentNullException(nameof(optionsMonitor));
            _cookieManager = cookieManager ?? throw new ArgumentNullException(nameof(cookieManager));
        }

        public IViewComponentResult Invoke(TagKind tagKind)
        {
            var googleTagManagerId = CookieManager.GoogleTagManagerId;
            var googleAnalyticsId = CookieManager.GoogleAnalyticsPropertyId;

            if (!string.IsNullOrEmpty(googleTagManagerId) && !string.IsNullOrEmpty(googleAnalyticsId))
            {
                switch (tagKind)
                {
                    case TagKind.HeadScript:
                        if (_cookieManager.VisitorCookiesEnabled)
                        {
                            return View("HeadScript", googleTagManagerId);
                        }
                        break;
                    case TagKind.Noscript:
                        if (_cookieManager.VisitorCookiesEnabled)
                        {
                            return View("Noscript", googleTagManagerId);
                        }
                        break;
                    case TagKind.Disabler:
                        if (_cookieManager.IsDefaultCookieLevel)
                        {
                            return View("Disabler", googleAnalyticsId);
                        }
                        break;
                    default:
                        return Content(string.Empty);
                }
            }

            return Content(string.Empty);
        }

        public enum TagKind
        {
            HeadScript,
            Noscript,
            Disabler
        }
    }
}
