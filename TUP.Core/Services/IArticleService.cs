﻿using Examine;
using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace TUP.Core.Services
{
    public interface IArticleService
    {
        IEnumerable<ISearchResult> GetLatestArticlesUsingExamine(IPublishedContent currentContentItem);

        IEnumerable<IPublishedContent> GetLatestArticlesUsingXPath(IPublishedContent currentContentItem);

        IEnumerable<IPublishedContent> GetLatestArticlesUsingDescendants(IPublishedContent currentContentItem);
    }
}
