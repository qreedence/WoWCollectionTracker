namespace SharedModels.Models
{
    public class Item
    {
        public Links _links { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Quality quality { get; set; }
        public int level { get; set; }
        public int required_level { get; set; }
        public Media media { get; set; }
        public ItemClass ItemClass { get; set; }
        public ItemSubclass ItemSubclass { get; set; }
        public InventoryType InventoryType { get; set; }
        public int PurchasePrice { get; set; }
        public int SellPrice { get; set; }
        public int MaxCount { get; set; }
        public bool IsEquippable { get; set; }
        public bool IsStackable { get; set; }
        public string description { get; set; }
        public PreviewItem preview_item { get; set; }
        public List<Spell> spells { get; set; }
        public Requirements Requirements { get; set; }
        public int PurchaseQuantity { get; set; }
        public MediaObject MediaObject { get; set; }
    }
    public class Quality
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
    public class ItemClass
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class ItemSubclass
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class InventoryType
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
    public class PreviewItem
    {
        public Item Item { get; set; }
        public Quality Quality { get; set; }
        public string Name { get; set; }
        public Media Media { get; set; }
        public ItemClass ItemClass { get; set; }
        public ItemSubclass ItemSubclass { get; set; }
        public InventoryType InventoryType { get; set; }
        public Binding Binding { get; set; }
        public List<Spell> Spells { get; set; }
        public Requirements Requirements { get; set; }
        public int PurchaseQuantity { get; set; }
    }
    public class Binding
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
    public class Spell
    {
        public SpellDetail _spell { get; set; }
        public string description { get; set; }
    }
    public class SpellDetail
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
