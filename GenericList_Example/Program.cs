using System;
using System.Collections.Generic;

namespace GenericList_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of code used during a Technical Interview.");
        }

        private List<MenuToolboxItem> ToolBoxItems { get; set; }
        private List<PrimaryMenuItem> TopLevelMenuItems { get; set; }
        private List<MegaMenuDevMenuItemGroup> MenuItemGroups { get; set; }
        private List<MegaMenuDevMenuItem> MenuItems { get; set; }
        private List<MegaMenuDevMenuItemImage> MenuItemImages { get; set; }
        private List<MegaMenuDevMenuItemContentItem> MenuContentItems { get; set; }
        private List<MegaMenuDevMenuItemQuery> MenuItemQueries { get; set; }
        private List<MegaMenuDevMenuItemBishop> MenuItemBishop { get; set; }
        private List<MegaMenuDevMenuItemStatement> MenuItemStatements { get; set; }

        private void PopulateGetCachedData()
        {
            ToolBoxItems = GenericList<MenuToolboxItem>();
            TopLevelMenuItems = GenericList<PrimaryMenuItem>();
            MenuItemGroups = GenericList<MegaMenuDevMenuItemGroup>();
            MenuItems = GenericList<MegaMenuDevMenuItem>();
            MenuItemImages = GenericList<MegaMenuDevMenuItemImage>();
            MenuContentItems = GenericList<MegaMenuDevMenuItemContentItem>();
            MenuItemQueries = GenericList<MegaMenuDevMenuItemQuery>();
            MenuItemBishop = GenericList<MegaMenuDevMenuItemBishop>();
            MenuItemStatements = GenericList<MegaMenuDevMenuItemStatement>();

        }

        //This is the Generic List created from the method beloow
        //Instead of using all of those methods, 
        //all of them can be substitable for this generic list
        private List<T> GenericList<T>()
        {
            List<T> items = new List<T>();

            try
            {
                HttpContext.Current = null;

                using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
                {
                    context.ObjectTrackingEnabled = false;
                    items = context.GetList<T>(LIST_NAME).ToList();
                }
            }
            finally
            {
                HttpContext.Current = httpContext;
            }
            return items;
        }

        //private List<MenuToolboxItem> GetToolBoxItems()
        //{
        //    List<MenuToolboxItem> items = new List<MenuToolboxItem>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MenuToolboxItem>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<PrimaryMenuItem> GetTopLevelItems()
        //{
        //    List<PrimaryMenuItem> items = new List<PrimaryMenuItem>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<PrimaryMenuItem>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItemGroup> GetMenuItemGroups()
        //{
        //    List<MegaMenuDevMenuItemGroup> items = new List<MegaMenuDevMenuItemGroup>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItemGroup>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItem> GetMenuItems()
        //{
        //    List<MegaMenuDevMenuItem> items = new List<MegaMenuDevMenuItem>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItem>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItemImage> GetMenuItemImages()
        //{
        //    List<MegaMenuDevMenuItemImage> items = new List<MegaMenuDevMenuItemImage>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItemImage>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItemContentItem> GetMenuItemContentQueries()
        //{
        //    List<MegaMenuDevMenuItemContentItem> items = new List<MegaMenuDevMenuItemContentItem>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItemContentItem>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItemQuery> GetMenuItemQueries()
        //{
        //    List<MegaMenuDevMenuItemQuery> items = new List<MegaMenuDevMenuItemQuery>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItemQuery>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItemBishop> GetMenuItemBishop()
        //{
        //    List<MegaMenuDevMenuItemBishop> items = new List<MegaMenuDevMenuItemBishop>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItemBishop>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}

        //private List<MegaMenuDevMenuItemStatement> GetMenuItemStatements()
        //{
        //    List<MegaMenuDevMenuItemStatement> items = new List<MegaMenuDevMenuItemStatement>();

        //    try
        //    {
        //        HttpContext.Current = null;

        //        using (MegaMenuContext context = new MegaMenuContext(ConfigurationSiteUrl))
        //        {
        //            context.ObjectTrackingEnabled = false;
        //            items = context.GetList<MegaMenuDevMenuItemStatement>(LIST_NAME).ToList();
        //        }
        //    }
        //    finally
        //    {
        //        HttpContext.Current = httpContext;
        //    }
        //    return items;
        //}
    }
}
