﻿using System.Collections.Generic;
using EPiServer.Data;
using Geta.SEO.Sitemaps.Entities;

namespace Geta.SEO.Sitemaps.Services
{
    public interface ISitemapRepository
    {
        void Delete(Identity id);

        IList<SitemapData> GetAllSitemapData();

        SitemapData GetSitemapData(Identity id);

        SitemapData GetSitemapData(string requestUrl);

        void Save(SitemapData sitemapData);
    }
}