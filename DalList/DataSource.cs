using DalApi;
using DO;
using System.Reflection.Metadata.Ecma335;

namespace Dal;

internal static class DataSource
{
    //internal static List<Product?> Products = new List<Product?>();
    //internal static List<Customer?> Customers = new List<Customer?>();
    //internal static List<Sale?> Sales = new List<Sale?>();
    internal static List<Customer> Customers { get; set; } = new List<Customer>
    {
        new Customer(123456789, "יוסי וולפין", "רחוב רבי עקיבא 1", "054-8523654"),
        new Customer(524896315, "מירי שמעונוביץ", "רחוב הדקל 33", "052-7648157"),
        new Customer(784512540, "ישראל לוי", "רחוב נתיבות המשפט 46", "053-4178439"),
        new Customer(978451260, "אליהו שפירא", "רחוב קצות החושן 3", "050-4173322"),
        new Customer(301245987, "יעל כהן", "רחוב מיימון 40", "052-7196610"),
        new Customer(349167255, "צבי נתנזון", "רחוב חפץ חיים 5", "052-7691004"),
        new Customer(488751996, "שמעון כהנא", "1רחוב הזית 6", "0556731122"),
        new Customer(789452154, "תהילה מאירוביץ", "רחוב כהנמו 7", "050-4177777"),
        new Customer(847596321, "אפרת ברמן", "רחוב שדה חמד 85", "050-4188888"),
        new Customer(457896321, "נח פיין", "רחוב נודע ביהודה 32", "050-4199999"),
        new Customer(302100245, "תמר פנט", "רחוב שאגת אריה 47", "050-4110101"),
        new Customer(875964587, "אלישבע קלרמן", "רחוב ירושליים 86", "050-4101212"),
        new Customer(306541789, "ציבי פציפיצי", "רחוב טבריה 33", "050-4101111"),
        new Customer(741258475, "חיים בלומנטל", "רחוב חזון איש 12", "050-4104141"),
        new Customer(784512036, "ריקי צביון", "רחוב אמרי ברוך 11", "050-4101616"),
        new Customer(702156348, "דיתי צולק", "רחוב רבי טרפון 8", "050-4101515"),
        new Customer(963254875, "ליבי קליין", "רחוב הלל ושמאי 35", "050-41017777"),
        new Customer(963201478, "שירה רובין", "רחוב זבוטינסקי 76", "050-4101818"),
        new Customer(789632145, "אברהםם רוזנגרטן", "רחוב שדרות יחזקאל 45", "050-4101919"),
        new Customer(852036442, "יונתן חיימוביץ", "רחוב אני נזר 13", "050-4101111"),
        new Customer(665478110, "בלומי דשבסקי", "רחוב אבי עזרי 85", "050-4107847"),
        new Customer(978851420, "גולדי קרישבסקי", "רחוב קהילות יעקב 12", "050-4105555"),
        new Customer(776655332, "מוטי ויזל", "רחוב נחמיה 13", "050-4102222"),
        new Customer(445522336, "נפתלי קמפה", "רחוב עזרא 55", "050-4104242"),
        new Customer(962578954, "מאיר קצבורג", "רחוב אבו חצירא 54", "050-4105252"),
        new Customer(300001254, "הדסה קרסניצקי", "רחוב סוקולוב 53", "050-4106262"),
        new Customer(753335753, "גבריאל בורגמן", "רחוב האדמור מנדבורנא 52", "050-4107272"),
        new Customer(966859668, "אביגיל דובדבני", "רחוב שלמה המלך 51", "050-4108282"),
        new Customer(410241024, "שמשון אלקובוביץ", "רחוב אלי הכהן 50", "050-4102278"),
        new Customer(301230125, "שמואל רוזובסקי", "רחוב הושע 75", "050-3030303"),
        new Customer(456456254, "פנינה סוקולובר", "רחוב צפניה 76", "050-3131313"),
        new Customer(753425735, "דבורי זליגוביץ", "רחוב שערי תשובה 77", "055-6734087"),
        new Customer(951842684, "דוד רוט", "רחוב מסילת יוסף 1", "055-6734158"),
        new Customer(357486958, "זהבי חדש", "רחוב הריטבא 2", "050-41003397"),
        new Customer(756458548, "מנדי וייס", "רחוב מהריל 3", "050-41008640"),
        new Customer(664458759, "דסי שטרן", "רחוב נתיבות שלום 4", "050-41008674"),
        new Customer(741101410, "מנוחה שטרוכליץ", "רחוב הבעל שם טוב 5", "050-4107373"),
        new Customer(887578578, "רפאל רושניבסקי", "רחוב רוביץ 6", "050-4108383"),
        new Customer(965965965, "גדי אברמוביץ", "רחוב מירסקי 7", "050-4109393"),
        new Customer(863248632, "הלל אהרוני", "רחוב מינץ 8", "055-6737979"),
        new Customer(486248624, "גיטי קוט", "רחוב הטורים 9", "050-4141414"),
        new Customer(153979741, "בינה כץ", "רחוב מלכי ישראל 12", "050-41008677"),
        new Customer(304787487, "אפרים גורגוב", "רחוב חבקוק 40", "052-7114789"),
        new Customer(965326900, "חייקי ולנשטיין", "רחוב מלאכי 25", "050-4102321"),
        new Customer(784471578, "פערי הרצל", "רחוב רבי יהודה הנשיא 26", "052-7194444"),
        new Customer(123654789, "יהודה דוידוביץ", "רחוב רבי עקיבא 21", "052-7165329"),
        new Customer(987654321, "גרשון בראון", "רחוב רבי עקיבא 32", "052-7165321"),
        new Customer(103330155, "הודיה שכטר", "רחוב רב נתן 17", "055-6731245")
    };

    internal static List<Product> Products { get; set; } = new List<Product>
    {
        new Product(DataSource.Config.ProductCode, "האיש שלנו בירושליים", Categories.הסטוריה, 85.5, 15),
        new Product(DataSource.Config.ProductCode, "ילדי שי", Categories.ילדים, 15, 35),
        new Product(DataSource.Config.ProductCode, "לינאר", Categories.מבוגרים, 100, 6),
        new Product(DataSource.Config.ProductCode, "מי שימצמץ ראשון", Categories.נוער, 70, 3),
        new Product(DataSource.Config.ProductCode, "חכימאי דיהודאי", Categories.סיפורי_צדיקים, 105, 10),
        new Product(DataSource.Config.ProductCode, "המלך שלומאי", Categories.ילדים, 15, 23),
        new Product(DataSource.Config.ProductCode, "מעבר לנהר הגועש", Categories.ילדים, 45, 16),
        new Product(DataSource.Config.ProductCode, "סיפור לשבת", Categories.סיפורי_צדיקים, 150, 9),
        new Product(DataSource.Config.ProductCode, "הבית בראש ההר", Categories.נוער, 55.5, 8),
        new Product(DataSource.Config.ProductCode, "קומיקס סבא", Categories.ילדים, 10, 35),
        new Product(DataSource.Config.ProductCode, "קשר גורדי", Categories.מבוגרים, 140, 21),
        new Product(DataSource.Config.ProductCode, "ילדי רב החובל", Categories.ילדים, 15, 35),
        new Product(DataSource.Config.ProductCode, "כי אשמרא שבת", Categories.סיפורי_צדיקים, 56, 3),
        new Product(DataSource.Config.ProductCode, "שברי אדם", Categories.מבוגרים, 99.9, 2),
        new Product(DataSource.Config.ProductCode, "מדון", Categories.הסטוריה, 120, 15),
        new Product(DataSource.Config.ProductCode, "סיפור לחג", Categories.סיפורי_צדיקים, 105, 19),
        new Product(DataSource.Config.ProductCode, "אוצר אגדות נ''ך", Categories.סיפורי_צדיקים, 199.9, 4),
        new Product(DataSource.Config.ProductCode, "חד וחלק", Categories.נוער, 150, 6),
        new Product(DataSource.Config.ProductCode, "לא מעבר לאוקינוס", Categories.ילדים, 25, 4),
        new Product(DataSource.Config.ProductCode, "אוהב ישראל", Categories.סיפורי_צדיקים, 142, 48),
        new Product(DataSource.Config.ProductCode, "יללה בחולות", Categories.ילדים, 20, 20),
        new Product(DataSource.Config.ProductCode, "געציל או ג'וחא", Categories.ילדים, 23, 17),
        new Product(DataSource.Config.ProductCode, "ממני בני", Categories.נוער, 20, 16),
        new Product(DataSource.Config.ProductCode, "החוקרים", Categories.נוער, 65, 10),
        new Product(DataSource.Config.ProductCode, "מלכיאל דש", Categories.ילדים, 46, 14),
        new Product(DataSource.Config.ProductCode, "משלי מגדים", Categories.סיפורי_צדיקים, 85.5, 15),
        new Product(DataSource.Config.ProductCode, "אורחות צדיקים", Categories.סיפורי_צדיקים, 180, 35),
        new Product(DataSource.Config.ProductCode, "ממני יוסי", Categories.נוער, 20, 20),
        new Product(DataSource.Config.ProductCode, "דודי ואודי", Categories.נוער, 79.9, 13),
        new Product(DataSource.Config.ProductCode, "חוצים גבולות", Categories.ילדים, 79.9, 10),
    };

    internal static  List<Sale> Sales { get; set; } = new List<Sale>
    {
        new Sale(DataSource.Config.SaleCode, 100, 3, 100, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(DataSource.Config.SaleCode, 101, 10, 85, false, new DateTime(2024, 11, 04), new DateTime(2024, 11, 28)),
        new Sale(DataSource.Config.SaleCode, 102, 5, 90, true, new DateTime(2024, 01, 07), new DateTime(2024, 03, 07)),
        new Sale(DataSource.Config.SaleCode, 103, 35, 50, true, new DateTime(2024, 09, 25), new DateTime(2024, 10, 13)),
        new Sale(DataSource.Config.SaleCode, 104, 7, 45, false, new DateTime(2025, 01, 19), new DateTime(2024, 02, 19)),
        new Sale(DataSource.Config.SaleCode, 105, 3, 13, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(DataSource.Config.SaleCode, 106, 2, 40, false, new DateTime(2024, 11, 04), new DateTime(2024, 11, 28)),
        new Sale(DataSource.Config.SaleCode, 107, 1, 100, true, new DateTime(2024, 01, 07), new DateTime(2024, 03, 07)),
        new Sale(DataSource.Config.SaleCode, 108, 2, 50, true, new DateTime(2024, 09, 25), new DateTime(2024, 10, 13)),
        new Sale(DataSource.Config.SaleCode, 109, 2, 8, false, new DateTime(2025, 01, 19), new DateTime(2024, 02, 19)),
        new Sale(DataSource.Config.SaleCode, 110, 5, 100, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(DataSource.Config.SaleCode, 111, 2, 12, false, new DateTime(2024, 11, 04), new DateTime(2024, 11, 28)),
        new Sale(DataSource.Config.SaleCode, 112, 1, 40, true, new DateTime(2024, 01, 07), new DateTime(2024, 03, 07)),
        new Sale(DataSource.Config.SaleCode, 113, 1, 70, true, new DateTime(2024, 09, 25), new DateTime(2024, 10, 13)),
        new Sale(DataSource.Config.SaleCode, 114, 2, 115, false, new DateTime(2025, 01, 19), new DateTime(2024, 02, 19)),
    };

    internal static class Config
    {
        internal const int ProductMinCode = 100;
        internal const int SaleMinCode = 200;

        private static int ProductIndex = ProductMinCode;
        private static int SaleIndex = SaleMinCode;

        public static int ProductCode
        {
            get
            {
                return ProductIndex++;
                /*int temp = ProductIndex;
                ProductIndex += 10;
                return temp;*/
            }
        }

        public static int SaleCode
        {
            get
            {
                return SaleIndex++;
            }
        }
    }
}
