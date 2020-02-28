﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Atlas.Models
{
    public class PermissionSet
    {
        public Guid Id { get; private set; }
        public Guid SiteId { get; private set; }
        public string Name { get; private set; }

        //modelBuilder.Entity<Book>()
        //.FindNavigation(nameof(Book.Reviews))
        //.SetPropertyAccessMode(PropertyAccessMode.Field);
        private List<Permission> _permissions;
        public ReadOnlyCollection<Permission> Permissions => _permissions.AsReadOnly();

        public PermissionSet()
        {
            
        }

        public PermissionSet(Guid siteId, string name, List<Permission> permissions)
        {
            Id = Guid.NewGuid();
            SiteId = siteId;
            Name = name;
            _permissions = permissions;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdatePermissions(List<Permission> permissions)
        {
            _permissions.Clear();
            _permissions = permissions;
        }
    }
}
