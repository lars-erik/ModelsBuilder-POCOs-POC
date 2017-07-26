## Interesting parts

There are two copies of generated modelbuilder classes under `MbPocoPoc.Web\Models`.  
These copy properties over to pocos. It should be by convention, and then by configuration.  
The configuration need to be independent of generated classes, since it might be made before the document types actually exist.

They map to POCOs under `MbPocoPoc.Core`. They also implement `IHaveProxy` to expose the mapped POCOs.  
There's one controller under `Web\Controllers` that might be a default controller or even in the model factory.  
It replaces the `RenderModel` with a POCO model and passes it to the template.  
The template uses `UmbracoViewPage<TPoco>` as its base, so we're completely without dependencies on `IPublishedContent`.

Feel free to fork / mess with it / discuss under issues / whatever.  
The sample is provided as-is with no guarantees, promises or responsibilities attached.

User/Pass: admin@admin.com / adminadmin