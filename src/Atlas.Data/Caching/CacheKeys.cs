﻿using System;

namespace Atlas.Data.Caching
{
    public static class CacheKeys
    {
        public static string Site(string siteName) => $"Site | SiteNme: {siteName}";
        public static string Categories(Guid siteId) => $"Categories | SiteId: {siteId}";
        public static string PermissionSet(Guid permissionSetId) => $"PermissionSet | PermissionSetId: {permissionSetId}";
        public static string Forums(Guid categoryId) => $"Forums | CategoryId: {categoryId}";
    }
}