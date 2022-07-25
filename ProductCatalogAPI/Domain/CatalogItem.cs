namespace ProductCatalogAPI.Domain
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public int CatalogTypeId { get; set; }
        public int CatalogBrandId { get; set; }
        
        //navigation to other table
        public virtual CatalogBrand CatalogBrand { get; set; }
        public virtual CatalogType CatalogType { get; set; }
    }
}
