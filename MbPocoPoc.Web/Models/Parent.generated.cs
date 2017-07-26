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
	/// <summary>Parent</summary>
	[PublishedContentModel("parent")]
	public partial class Parent : PublishedContentModel, MbPocoPoc.Core.IHaveProxy
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "parent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

	    private MbPocoPoc.Core.Parent proxy;

	    object MbPocoPoc.Core.IHaveProxy.Proxy
	    {
            get { return Proxy; }
	    }

	    public MbPocoPoc.Core.Parent Proxy
	    {
            get { return proxy; }
	    }

	    public Parent(IPublishedContent content)
	        : base(content)
	    {
	        proxy = new MbPocoPoc.Core.Parent();
	        proxy.RichText = RichText;
	    }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Parent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// RichText
		///</summary>
		[ImplementPropertyType("richText")]
		public IHtmlString RichText
		{
			get { return this.GetPropertyValue<IHtmlString>("richText"); }
		}
	}
}
