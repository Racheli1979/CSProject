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
        new Customer(678901234, "רחל שמואלי", "רחוב חרוב 6", "050-6789012"),
        new Customer(123456789, "יוסי לוי", "רחוב פטל 1", "050-1111111"),
        new Customer(234567890, "מיה כהן", "רחוב שקד 2", "050-2222222"),
        new Customer(345678901, "דוד ישראלי", "רחוב תמר 3", "050-3333333"),
        new Customer(456789012, "שרה פז", "רחוב זית 4", "050-4444444"),
        new Customer(567890123, "אבי רוזן", "רחוב דקל 5", "050-5555555"),
        new Customer(678901345, "רונית שמואלי", "רחוב אלון 6", "050-6666666"),
        new Customer(789012456, "אלי ברק", "רחוב אורן 7", "050-7777777"),
        new Customer(890123567, "תמר נעים", "רחוב חרוב 8", "050-8888888"),
        new Customer(901234678, "משה בן דוד", "רחוב דובדבן 9", "050-9999999"),
        new Customer(123456780, "חנה גולדשטיין", "רחוב אפרסק 10", "050-1010101"),
        new Customer(234567891, "עדי שטרן", "רחוב רימון 11", "050-1212121"),
        new Customer(345678902, "גיא עוז", "רחוב ברוש 12", "050-1313131"),
        new Customer(456789013, "נועה בן חיים", "רחוב דקל 13", "050-1414141"),
        new Customer(567890124, "יואב מזרחי", "רחוב תמר 14", "050-1515151"),
        new Customer(678901235, "דנה סלע", "רחוב פטל 15", "050-1616161"),
        new Customer(789012346, "אורן לוי", "רחוב שקד 16", "050-1717171"),
        new Customer(890123457, "רוני כהן", "רחוב זית 17", "050-1818181"),
        new Customer(901234568, "ליה שקד", "רחוב אורן 18", "050-1919191"),
        new Customer(123456791, "טל עוז", "רחוב חרוב 19", "050-2020202"),
        new Customer(234567892, "אורי ברק", "רחוב דובדבן 20", "050-2121212"),
        new Customer(345678903, "אורית דיין", "רחוב גפן 21", "050-2222223"),
        new Customer(456789014, "שי רפאלי", "רחוב סיגל 22", "050-2323232"),
        new Customer(567890125, "נטלי עיני", "רחוב דקל 23", "050-2424242"),
        new Customer(678901236, "רן וולף", "רחוב חצב 24", "050-2525252"),
        new Customer(789012347, "דניאל ברוש", "רחוב נרקיס 25", "050-2626262"),
        new Customer(890123458, "מאיה לב", "רחוב שקד 26", "050-2727272"),
        new Customer(901234579, "עומרי טל", "רחוב תמר 27", "050-2828282"),
        new Customer(123456792, "אביגיל שוקרון", "רחוב דובדבן 28", "050-2929292"),
        new Customer(234567893, "רז חכם", "רחוב פטל 29", "050-3030303"),
        new Customer(345678904, "שקד נבון", "רחוב רימון 30", "050-3131313"),
        new Customer(456789015, "עידו לוי", "רחוב זית 31", "050-3232323"),
        new Customer(567890126, "ליאון רז", "רחוב אלון 32", "050-3333333"),
        new Customer(678901237, "אורלי שטרן", "רחוב חרוב 33", "050-3434343"),
        new Customer(789012348, "עידן גולן", "רחוב שקד 34", "050-3535353"),
        new Customer(890123459, "רוני גולן", "רחוב נרקיס 35", "050-3636363"),
        new Customer(901234580, "סיון פז", "רחוב דקל 36", "050-3737373"),
        new Customer(123456793, "אורי בן חיים", "רחוב ברוש 37", "050-3838383"),
        new Customer(234567894, "מאיה יוסף", "רחוב תמר 38", "050-3939393"),
        new Customer(345678905, "תמיר עוז", "רחוב דובדבן 39", "050-4040404"),
        new Customer(456789016, "ליה מזרחי", "רחוב אפרסק 40", "050-4141414"),
        new Customer(567890127, "טליה גולד", "רחוב חצב 41", "050-4242424"),
        new Customer(678901238, "אורי ברק", "רחוב זית 42", "050-4343434"),
        new Customer(789012349, "עדי שקד", "רחוב אורן 43", "050-4444444"),
        new Customer(890123460, "דודו טל", "רחוב פטל 44", "050-4545454"),
        new Customer(901234581, "אורן שמואלי", "רחוב שקד 45", "050-4646464")
    };

    /*internal static List<Product> Products { get; set; } = new List<Product>
    {
        new Product(DataSource.Config.SaleCode, "מה שבטוח אני לא מחליטה- מה שבטוח הורדתי שליטה", Categories.History, 19.99, 100),
        new Product(0, "קושי=מחמאה- העלתי אותך הקבצה", Categories.Children, 29.99, 200),
        new Product(0, "ד' מצייר את הציור ואת בוחרת באיזה צבעים לצבוע אותו", Categories.Children, 39.99, 150),
        new Product(0, "הוי מתפלל וחוזר ומתפלל ויש שעה שנותנים לך", Categories.Children, 49.99, 80),
        new Product(0, "ואפילו אם יעברו כמה ימים ושנים אשר ידמו לו שלא הועילה תפילתו כלום, אל יניח מלהתפלל, סוף סוף יראה בעיניו שתפילתו הועילה לו מאוד(סטיפלר)", Categories.Children, 59.99, 60),
        new Product(0, "כשתהיה עומד להתפלל יהא לבך שמח עליך שאתה מתפלל לאלוקים שאין כיוצא בו (מס\"י)", Categories.Children, 69.99, 40),
        new Product(0, "הוא אמר: \"שלום!\"", Categories.Children, 79.99, 20),
        new Product(0, "הקב\"ה עומד לידך ומשתוקק לשמוע אותך", Categories.Children, 99.99, 100),
        new Product(0, "אלוקי... אם תשרפני באש לא הוסיף כי אם אהבה ושמחה בך (חובת הלבבות)", Categories.Children, 49.99, 50),
        new Product(0, "\"אהבת עולם אהבתיך על כן משכתיך חסד\" (ירמיה)", Categories.Children , 199.99, 30),
        new Product(0, "\"אהבתי אתכם אמר ד'\" (מלאכי)", Categories.Children, 79.99, 20),
        new Product(0, "\"תמים תהיה עם ד' אלוקיך\" (דברים)", Categories.Children, 29.99, 70),
        new Product(0, "\"ד' רעי לא אחסר\" (תהילים)", Categories.Children, 59.99, 80),
        new Product(0, "\"חרדת אדם יתן מוקש ובוטח בד' יסוגב\"- יסוגב מן הצרה (רבינו יונה)", Categories.Children, 299.99, 10),
        new Product(0, "התפקיד שלנו הוא להפוך כל קושי- לאתגר", Categories.Children, 15.99, 150),
        new Product(0, "סומכים עליך מהשמים שתקחי אחריות", Categories.Children, 149.99, 90),
        new Product(0, "התגברות = התעלות", Categories.Children, 99.99, 100),
        new Product(0, "כל יהודי בכל מצב ורמה הוא יהלום יקר המאיר בכל העולמות", Categories.Children, 49.99, 50),
        new Product(0, "לכל יהודי יש נקודה טובה ומעלה מיוחדת", Categories.Children, 199.99, 30),
        new Product(0, "להבין ביהלומים", Categories.Children, 79.99, 20),
        new Product(0, "\" כי אשב בחושך ד' אור לי\"- \"לולי שישבתי בחושך לא היה ד' אור לי\"", Categories.Children, 29.99, 70),
        new Product(0, "-\t\"זה היום עשה ד' נגילה ונשמחה בו\"", Categories.Children, 59.99, 80),
        new Product(0, "יש צדיק גוזר וד' מקיים ודרגה גבוהה יותר - ד' גוזר וצדיק מקיים", Categories.Children, 299.99, 10),
        new Product(0, "יש ילד שמאכילים אותו בכפית, אבל כשגדלים לפעמים ד' רוצה שנאכל לבד, גם אם כל האוכל נשפך, זה שווה!", Categories.Children, 15.99, 150),
        new Product(0, "מה ישמח עכשיו את הקב\"ה?", Categories.Children, 149.99, 90),
        new Product(0, "והנה ד' ניצב עליו מלא כל הארץ כבודו מביט עליו ובוחן כליות ולב אם עבדו כראוי", Categories.Children, 99.99, 100),
        new Product(0, "מוצר 20", Categories.Children, 49.99, 50),
        new Product(0, "מוצר 21", Categories.Children, 199.99, 30),
        new Product(0, "מוצר 22", Categories.Children, 79.99, 20),
        new Product(0, "מוצר 23", Categories.Children, 29.99, 70),
        new Product(0, "מוצר 24", Categories.Children, 59.99, 80),
        new Product(0, "מוצר 25", Categories.Children, 299.99, 10)
    };*/
    internal static List<Product> Products { get; set; } = new List<Product>
    {
        new Product(DataSource.Config.ProductCode, "Aish shelanu birushalim", Categories.הסטוריה, 85.5, 15),
        new Product(DataSource.Config.ProductCode, "Yaldy yshay", Categories.ילדים, 15, 35),
        new Product(DataSource.Config.ProductCode, "Linur", Categories.מבוגרים, 100, 6),
        new Product(DataSource.Config.ProductCode, "Mi sheyematzmetz rishon", Categories.נוער, 70, 3),
        new Product(DataSource.Config.ProductCode, "Chakimy deyehuday", Categories.סיפורי_צדיקים, 105, 10)
    };

    internal static  List<Sale> Sales { get; set; } = new List<Sale>
    {
        new Sale(DataSource.Config.SaleCode, 100, 3, 100, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(DataSource.Config.SaleCode, 101, 10, 85, false, new DateTime(2024, 11, 04), new DateTime(2024, 11, 28)),
        new Sale(DataSource.Config.SaleCode, 102, 5, 90, true, new DateTime(2024, 01, 07), new DateTime(2024, 03, 07)),
        new Sale(DataSource.Config.SaleCode, 100, 35, 50, true, new DateTime(2024, 09, 25), new DateTime(2024, 10, 13)),
        new Sale(DataSource.Config.SaleCode, 103, 7, 45, false, new DateTime(2025, 01, 19), new DateTime(2024, 02, 19))
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
