//------------------------------------------------------------------------------
// This is a copied version of the generated class.
// We'll need to modify builders (extend?) to be able to create the proxy code.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Child</summary>
	[PublishedContentModel("child")]
	public partial class Child : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "child";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

	    private MbPocoPoc.Core.Child proxy;

	    public MbPocoPoc.Core.Child Proxy
	    {
	        get { return proxy; }
	    }

        public Child(IPublishedContent content) : base(content)
	    {
	        proxy = new MbPocoPoc.Core.Child();
	        proxy.Checkboxes = Checkboxes;
	    }

#pragma warning disable 0109 // new is redundant
        public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Child, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Checkboxes
		///</summary>
		[ImplementPropertyType("checkboxes")]
		public IEnumerable<string> Checkboxes
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("checkboxes"); }
		}
	}
}
