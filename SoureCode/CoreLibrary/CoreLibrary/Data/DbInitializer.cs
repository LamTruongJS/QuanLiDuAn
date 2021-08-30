using CoreLibrary.Areas.Reader.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(EBookContext context)
        {
            await context.Database.EnsureCreatedAsync();
            // trả về true khi chưa tồn tại database
            // trả về false khi nếu đã tồn tại database

            bool hasCategories = context.Categories.Any();
            bool hasLanguages = context.Languages.Any();
            bool hasCountries = context.Countries.Any();
            //bool hasRoles = await roleManager.RoleExistsAsync("Author") && await roleManager.RoleExistsAsync("Reader")
            //    && await roleManager.RoleExistsAsync("Assitant") && await roleManager.RoleExistsAsync("Admin");
            bool hasRoles = context.Roles.Any();

            if (hasCategories && hasLanguages && hasCountries && hasRoles)
            {
                return;
            }
            if (!hasLanguages)
            {
                var languages = new Language[]
                {
                    #region Language
                        new Language {Id = "af", Name = "Afrikaans"},

                        new Language {Id = "sq", Name = "Albanian - shqip"},

                        new Language {Id = "am", Name = "Amharic - አማርኛ"},

                        new Language {Id = "ar", Name = "Arabic - العربية"},

                        new Language {Id = "an", Name = "Aragonese - aragonés"},

                        new Language {Id = "hy", Name = "Armenian - հայերեն"},

                        new Language {Id = "ast", Name = "Asturian - asturianu"},

                        new Language {Id = "az", Name = "Azerbaijani - azərbaycan dili"},

                        new Language {Id = "eu", Name = "Basque - euskara"},

                        new Language {Id = "be", Name = "Belarusian - беларуская"},

                        new Language {Id = "bn", Name = "Bengali - বাংলা"},

                        new Language {Id = "bs", Name = "Bosnian - bosanski"},

                        new Language {Id = "br", Name = "Breton - brezhoneg"},

                        new Language {Id = "bg", Name = "Bulgarian - български"},

                        new Language {Id = "ca", Name = "Catalan - català"},

                        new Language {Id = "ckb", Name = "Central Kurdish - کوردی (دەستنوسی عەرەبی)"},

                        new Language {Id = "zh", Name = "Chinese - 中文"},

                        new Language {Id = "zh-HK", Name = "Chinese (Hong Kong) - 中文（香港）"},

                        new Language {Id = "zh-CN", Name = "Chinese (Simplified) - 中文（简体）"},

                        new Language {Id = "zh-TW", Name = "Chinese (Traditional) - 中文（繁體）"},

                        new Language {Id = "co", Name = "Corsican"},

                        new Language {Id = "hr", Name = "Croatian - hrvatski"},

                        new Language {Id = "cs", Name = "Czech - čeština"},

                        new Language {Id = "da", Name = "Danish - dansk"},

                        new Language {Id = "nl", Name = "Dutch - Nederlands"},

                        new Language {Id = "en", Name = "English"},

                        new Language {Id = "en-AU", Name = "English (Australia)"},

                        new Language {Id = "en-CA", Name = "English (Canada)"},

                        new Language {Id = "en-IN", Name = "English (India)"},

                        new Language {Id = "en-NZ", Name = "English (New Zealand)"},

                        new Language {Id = "en-ZA", Name = "English (South Africa)"},

                        new Language {Id = "en-GB", Name = "English (United Kingdom)"},

                        new Language {Id = "en-US", Name = "English (United States)"},

                        new Language {Id = "eo", Name = "Esperanto - esperanto"},

                        new Language {Id = "et", Name = "Estonian - eesti"},

                        new Language {Id = "fo", Name = "Faroese - føroyskt"},

                        new Language {Id = "fil", Name = "Filipino"},

                        new Language {Id = "fi", Name = "Finnish - suomi"},

                        new Language {Id = "fr", Name = "French - français"},

                        new Language {Id = "fr-CA", Name = "French (Canada) - français (Canada)"},

                        new Language {Id = "fr-FR", Name = "French (France) - français (France)"},

                        new Language {Id = "fr-CH", Name = "French (Switzerland) - français (Suisse)"},

                        new Language {Id = "gl", Name = "Galician - galego"},

                        new Language {Id = "ka", Name = "Georgian - ქართული"},

                        new Language {Id = "de", Name = "German - Deutsch"},

                        new Language {Id = "de-AT", Name = "German (Austria) - Deutsch (Österreich)"},

                        new Language {Id = "de-DE", Name = "German (Germany) - Deutsch (Deutschland)"},

                        new Language {Id = "de-LI", Name = "German (Liechtenstein) - Deutsch (Liechtenstein)"},

                        new Language {Id = "de-CH", Name = "German (Switzerland) - Deutsch (Schweiz)"},

                        new Language {Id = "el", Name = "Greek - Ελληνικά"},

                        new Language {Id = "gn", Name = "Guarani"},

                        new Language {Id = "gu", Name = "Gujarati - ગુજરાતી"},

                        new Language {Id = "ha", Name = "Hausa"},

                        new Language {Id = "haw", Name = "Hawaiian - ʻŌlelo Hawaiʻi"},

                        new Language {Id = "he", Name = "Hebrew - עברית"},

                        new Language {Id = "hi", Name = "Hindi - हिन्दी"},

                        new Language {Id = "hu", Name = "Hungarian - magyar"},

                        new Language {Id = "is", Name = "Icelandic - íslenska"},

                        new Language {Id = "id", Name = "Indonesian - Indonesia"},

                        new Language {Id = "ia", Name = "Interlingua"},

                        new Language {Id = "ga", Name = "Irish - Gaeilge"},

                        new Language {Id = "it", Name = "Italian - italiano"},

                        new Language {Id = "it-IT", Name = "Italian (Italy) - italiano (Italia)"},

                        new Language {Id = "it-CH", Name = "Italian (Switzerland) - italiano (Svizzera)"},

                        new Language {Id = "ja", Name = "Japanese - 日本語"},

                        new Language {Id = "kn", Name = "Kannada - ಕನ್ನಡ"},

                        new Language {Id = "kk", Name = "Kazakh - қазақ тілі"},

                        new Language {Id = "km", Name = "Khmer - ខ្មែរ"},

                        new Language {Id = "ko", Name = "Korean - 한국어"},

                        new Language {Id = "ku", Name = "Kurdish - Kurdî"},

                        new Language {Id = "ky", Name = "Kyrgyz - кыргызча"},

                        new Language {Id = "lo", Name = "Lao - ລາວ"},

                        new Language {Id = "la", Name = "Latin"},

                        new Language {Id = "lv", Name = "Latvian - latviešu"},

                        new Language {Id = "ln", Name = "Lingala - lingála"},

                        new Language {Id = "lt", Name = "Lithuanian - lietuvių"},

                        new Language {Id = "mk", Name = "Macedonian - македонски"},

                        new Language {Id = "ms", Name = "Malay - Bahasa Melayu"},

                        new Language {Id = "ml", Name = "Malayalam - മലയാളം"},

                        new Language {Id = "mt", Name = "Maltese - Malti"},

                        new Language {Id = "mr", Name = "Marathi - मराठी"},

                        new Language {Id = "mn", Name = "Mongolian - монгол"},

                        new Language {Id = "ne", Name = "Nepali - नेपाली"},

                        new Language {Id = "no", Name = "Norwegian - norsk"},

                        new Language {Id = "nb", Name = "Norwegian Bokmål - norsk bokmål"},

                        new Language {Id = "nn", Name = "Norwegian Nynorsk - nynorsk"},

                        new Language {Id = "oc", Name = "Occitan"},

                        new Language {Id = "or", Name = "Oriya - ଓଡ଼ିଆ"},

                        new Language {Id = "om", Name = "Oromo - Oromoo"},

                        new Language {Id = "ps", Name = "Pashto - پښتو"},

                        new Language {Id = "fa", Name = "Persian - فارسی"},

                        new Language {Id = "pl", Name = "Polish - polski"},

                        new Language {Id = "pt", Name = "Portuguese - português"},

                        new Language {Id = "pt-BR", Name = "Portuguese (Brazil) - português (Brasil)"},

                        new Language {Id = "pt-PT", Name = "Portuguese (Portugal) - português (Portugal)"},

                        new Language {Id = "pa", Name = "Punjabi - ਪੰਜਾਬੀ"},

                        new Language {Id = "qu", Name = "Quechua"},

                        new Language {Id = "ro", Name = "Romanian - română"},

                        new Language {Id = "mo", Name = "Romanian (Moldova) - română (Moldova)"},

                        new Language {Id = "rm", Name = "Romansh - rumantsch"},

                        new Language {Id = "ru", Name = "Russian - русский"},

                        new Language {Id = "gd", Name = "Scottish Gaelic"},

                        new Language {Id = "sr", Name = "Serbian - српски"},

                        new Language {Id = "sh", Name = "Serbo-Croatian - Srpskohrvatski"},

                        new Language {Id = "sn", Name = "Shona - chiShona"},

                        new Language {Id = "sd", Name = "Sindhi"},

                        new Language {Id = "si", Name = "Sinhala - සිංහල"},

                        new Language {Id = "sk", Name = "Slovak - slovenčina"},

                        new Language {Id = "sl", Name = "Slovenian - slovenščina"},

                        new Language {Id = "so", Name = "Somali - Soomaali"},

                        new Language {Id = "st", Name = "Southern Sotho"},

                        new Language {Id = "es", Name = "Spanish - español"},

                        new Language {Id = "es-AR", Name = "Spanish (Argentina) - español (Argentina)"},

                        new Language {Id = "es-419", Name = "Spanish (Latin America) - español (Latinoamérica)"},

                        new Language {Id = "es-MX", Name = "Spanish (Mexico) - español (México)"},

                        new Language {Id = "es-ES", Name = "Spanish (Spain) - español (España)"},

                        new Language {Id = "es-US", Name = "Spanish (United States) - español (Estados Unidos)"},

                        new Language {Id = "su", Name = "Sundanese"},

                        new Language {Id = "sw", Name = "Swahili - Kiswahili"},

                        new Language {Id = "sv", Name = "Swedish - svenska"},

                        new Language {Id = "tg", Name = "Tajik - тоҷикӣ"},

                        new Language {Id = "ta", Name = "Tamil - தமிழ்"},

                        new Language {Id = "tt", Name = "Tatar"},

                        new Language {Id = "te", Name = "Telugu - తెలుగు"},

                        new Language {Id = "th", Name = "Thai - ไทย"},

                        new Language {Id = "ti", Name = "Tigrinya - ትግርኛ"},

                        new Language {Id = "to", Name = "Tongan - lea fakatonga"},

                        new Language {Id = "tr", Name = "Turkish - Türkçe"},

                        new Language {Id = "tk", Name = "Turkmen"},

                        new Language {Id = "tw", Name = "Twi"},

                        new Language {Id = "uk", Name = "Ukrainian - українська"},

                        new Language {Id = "ur", Name = "Urdu - اردو"},

                        new Language {Id = "ug", Name = "Uyghur"},

                        new Language {Id = "uz", Name = "Uzbek - o‘zbek"},

                        new Language {Id = "vi", Name = "Vietnamese - Tiếng Việt"},

                        new Language {Id = "wa", Name = "Walloon - wa"},

                        new Language {Id = "cy", Name = "Welsh - Cymraeg"},

                        new Language {Id = "fy", Name = "Western Frisian"},

                        new Language {Id = "xh", Name = "Xhosa"},

                        new Language {Id = "yi", Name = "Yiddish"},

                        new Language {Id = "yo", Name = "Yoruba - Èdè Yorùbá"},

                        new Language {Id = "zu", Name = "Zulu - isiZulu"}
                    #endregion
                };
                await context.Languages.AddRangeAsync(languages);
                await context.SaveChangesAsync();
            }

            if(!hasCategories)
            {
                var categories = new Category[]
                {
                    #region Category
                        new Category{Id = "CG0001", Name = "Classics"},
                        new Category{Id = "CG0002", Name = "Comic Book or Graphic Novel"},
                        new Category{Id = "CG0003", Name = "Horror"},
                        new Category{Id = "CG0004", Name = "Literary"},
                        new Category{Id = "CG0005", Name = "Romance"},
                        new Category{Id = "CG0006", Name = "Science"},
                        new Category{Id = "CG0007", Name = "Biographies and Autobiographies"},
                        new Category{Id = "CG0008", Name = "Cookbooks"},
                        new Category{Id = "CG0009", Name = "History"},
                        new Category{Id = "CG0010", Name = "Poetry"},
                        new Category{Id = "CG0011", Name = "Sport"},
                        new Category{Id = "CG0012", Name = "Computer"},
                        new Category{Id = "CG0013", Name = "Technology"},
                        new Category{Id = "CG0014", Name = "Language"},
                        new Category{Id = "CG0015", Name = "Other"}

                    #endregion
                };
                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }

            if (!hasCountries)
            {
                var countries = new Country[]
                {
                    #region Country
                    new Country {Id = "af", Name = "Afghanistan"},

                        new Country {Id = "ax", Name = "Aland Islands"},

                        new Country {Id = "al", Name = "Albania"},

                        new Country {Id = "dz", Name = "Algeria"},

                        new Country {Id = "as", Name = "American Samoa"},

                        new Country {Id = "ad", Name = "Andorra"},

                        new Country {Id = "ao", Name = "Angola"},

                        new Country {Id = "ai", Name = "Anguilla"},

                        new Country {Id = "aq", Name = "Antarctica"},

                        new Country {Id = "ag", Name = "Antigua and Barbuda"},

                        new Country {Id = "ar", Name = "Argentina"},

                        new Country {Id = "am", Name = "Armenia"},

                        new Country {Id = "aw", Name = "Aruba"},

                        new Country {Id = "au", Name = "Australia"},

                        new Country {Id = "at", Name = "Austria"},

                        new Country {Id = "az", Name = "Azerbaijan"},

                        new Country {Id = "bs", Name = "Bahamas"},

                        new Country {Id = "bh", Name = "Bahrain"},

                        new Country {Id = "bd", Name = "Bangladesh"},

                        new Country {Id = "bb", Name = "Barbados"},

                        new Country {Id = "by", Name = "Belarus"},

                        new Country {Id = "be", Name = "Belgium"},

                        new Country {Id = "bz", Name = "Belize"},

                        new Country {Id = "bj", Name = "Benin"},

                        new Country {Id = "bm", Name = "Bermuda"},

                        new Country {Id = "bt", Name = "Bhutan"},

                        new Country {Id = "bo", Name = "Bolivia"},

                        new Country {Id = "bq", Name = "Bonaire, Sint Eustatius and Saba"},

                        new Country {Id = "ba", Name = "Bosnia and Herzegovina"},

                        new Country {Id = "bw", Name = "Botswana"},

                        new Country {Id = "bv", Name = "Bouvet Island"},

                        new Country {Id = "br", Name = "Brazil"},

                        new Country {Id = "io", Name = "British Indian Ocean Territory"},

                        new Country {Id = "bn", Name = "Brunei Darussalam"},

                        new Country {Id = "bg", Name = "Bulgaria"},

                        new Country {Id = "bf", Name = "Burkina Faso"},

                        new Country {Id = "bi", Name = "Burundi"},

                        new Country {Id = "kh", Name = "Cambodia"},

                        new Country {Id = "cm", Name = "Cameroon"},

                        new Country {Id = "ca", Name = "Canada"},

                        new Country {Id = "cv", Name = "Cape Verde"},

                        new Country {Id = "ky", Name = "Cayman Islands"},

                        new Country {Id = "cf", Name = "Central African Republic"},

                        new Country {Id = "td", Name = "Chad"},

                        new Country {Id = "cl", Name = "Chile"},

                        new Country {Id = "cn", Name = "China"},

                        new Country {Id = "cx", Name = "Christmas Island"},

                        new Country {Id = "cc", Name = "Cocos (Keeling) Islands"},

                        new Country {Id = "co", Name = "Colombia"},

                        new Country {Id = "km", Name = "Comoros"},

                        new Country {Id = "cg", Name = "Congo"},

                        new Country {Id = "cd", Name = "Congo, Democratic Republic of the Congo"},

                        new Country {Id = "ck", Name = "Cook Islands"},

                        new Country {Id = "cr", Name = "Costa Rica"},

                        new Country {Id = "ci", Name = "Cote D'Ivoire"},

                        new Country {Id = "hr", Name = "Croatia"},

                        new Country {Id = "cu", Name = "Cuba"},

                        new Country {Id = "cw", Name = "Curacao"},

                        new Country {Id = "cy", Name = "Cyprus"},

                        new Country {Id = "cz", Name = "Czech Republic"},

                        new Country {Id = "dk", Name = "Denmark"},

                        new Country {Id = "dj", Name = "Djibouti"},

                        new Country {Id = "dm", Name = "Dominica"},

                        new Country {Id = "do", Name = "Dominican Republic"},

                        new Country {Id = "ec", Name = "Ecuador"},

                        new Country {Id = "eg", Name = "Egypt"},

                        new Country {Id = "sv", Name = "El Salvador"},

                        new Country {Id = "gq", Name = "Equatorial Guinea"},

                        new Country {Id = "er", Name = "Eritrea"},

                        new Country {Id = "ee", Name = "Estonia"},

                        new Country {Id = "et", Name = "Ethiopia"},

                        new Country {Id = "fk", Name = "Falkland Islands (Malvinas)"},

                        new Country {Id = "fo", Name = "Faroe Islands"},

                        new Country {Id = "fj", Name = "Fiji"},

                        new Country {Id = "fi", Name = "Finland"},

                        new Country {Id = "fr", Name = "France"},

                        new Country {Id = "gf", Name = "French Guiana"},

                        new Country {Id = "pf", Name = "French Polynesia"},

                        new Country {Id = "tf", Name = "French Southern Territories"},

                        new Country {Id = "ga", Name = "Gabon"},

                        new Country {Id = "gm", Name = "Gambia"},

                        new Country {Id = "ge", Name = "Georgia"},

                        new Country {Id = "de", Name = "Germany"},

                        new Country {Id = "gh", Name = "Ghana"},

                        new Country {Id = "gi", Name = "Gibraltar"},

                        new Country {Id = "gr", Name = "Greece"},

                        new Country {Id = "gl", Name = "Greenland"},

                        new Country {Id = "gd", Name = "Grenada"},

                        new Country {Id = "gp", Name = "Guadeloupe"},

                        new Country {Id = "gu", Name = "Guam"},

                        new Country {Id = "gt", Name = "Guatemala"},

                        new Country {Id = "gg", Name = "Guernsey"},

                        new Country {Id = "gn", Name = "Guinea"},

                        new Country {Id = "gw", Name = "Guinea-Bissau"},

                        new Country {Id = "gy", Name = "Guyana"},

                        new Country {Id = "ht", Name = "Haiti"},

                        new Country {Id = "hm", Name = "Heard Island and Mcdonald Islands"},

                        new Country {Id = "va", Name = "Holy See (Vatican City State)"},

                        new Country {Id = "hn", Name = "Honduras"},

                        new Country {Id = "hk", Name = "Hong Kong"},

                        new Country {Id = "hu", Name = "Hungary"},

                        new Country {Id = "is", Name = "Iceland"},

                        new Country {Id = "in", Name = "India"},

                        new Country {Id = "id", Name = "Indonesia"},

                        new Country {Id = "ir", Name = "Iran, Islamic Republic of"},

                        new Country {Id = "iq", Name = "Iraq"},

                        new Country {Id = "ie", Name = "Ireland"},

                        new Country {Id = "im", Name = "Isle of Man"},

                        new Country {Id = "il", Name = "Israel"},

                        new Country {Id = "it", Name = "Italy"},

                        new Country {Id = "jm", Name = "Jamaica"},

                        new Country {Id = "jp", Name = "Japan"},

                        new Country {Id = "je", Name = "Jersey"},

                        new Country {Id = "jo", Name = "Jordan"},

                        new Country {Id = "kz", Name = "Kazakhstan"},

                        new Country {Id = "ke", Name = "Kenya"},

                        new Country {Id = "ki", Name = "Kiribati"},

                        new Country {Id = "kp", Name = "Korea, Democratic People's Republic of"},

                        new Country {Id = "kr", Name = "Korea, Republic of"},

                        new Country {Id = "xk", Name = "Kosovo"},

                        new Country {Id = "kw", Name = "Kuwait"},

                        new Country {Id = "kg", Name = "Kyrgyzstan"},

                        new Country {Id = "la", Name = "Lao People's Democratic Republic"},

                        new Country {Id = "lv", Name = "Latvia"},

                        new Country {Id = "lb", Name = "Lebanon"},

                        new Country {Id = "ls", Name = "Lesotho"},

                        new Country {Id = "lr", Name = "Liberia"},

                        new Country {Id = "ly", Name = "Libyan Arab Jamahiriya"},

                        new Country {Id = "li", Name = "Liechtenstein"},

                        new Country {Id = "lt", Name = "Lithuania"},

                        new Country {Id = "lu", Name = "Luxembourg"},

                        new Country {Id = "mo", Name = "Macao"},

                        new Country {Id = "mk", Name = "Macedonia, the Former Yugoslav Republic of"},

                        new Country {Id = "mg", Name = "Madagascar"},

                        new Country {Id = "mw", Name = "Malawi"},

                        new Country {Id = "my", Name = "Malaysia"},

                        new Country {Id = "mv", Name = "Maldives"},

                        new Country {Id = "ml", Name = "Mali"},

                        new Country {Id = "mt", Name = "Malta"},

                        new Country {Id = "mh", Name = "Marshall Islands"},

                        new Country {Id = "mq", Name = "Martinique"},

                        new Country {Id = "mr", Name = "Mauritania"},

                        new Country {Id = "mu", Name = "Mauritius"},

                        new Country {Id = "yt", Name = "Mayotte"},

                        new Country {Id = "mx", Name = "Mexico"},

                        new Country {Id = "fm", Name = "Micronesia, Federated States of"},

                        new Country {Id = "md", Name = "Moldova, Republic of"},

                        new Country {Id = "mc", Name = "Monaco"},

                        new Country {Id = "mn", Name = "Mongolia"},

                        new Country {Id = "me", Name = "Montenegro"},

                        new Country {Id = "ms", Name = "Montserrat"},

                        new Country {Id = "ma", Name = "Morocco"},

                        new Country {Id = "mz", Name = "Mozambique"},

                        new Country {Id = "mm", Name = "Myanmar"},

                        new Country {Id = "na", Name = "Namibia"},

                        new Country {Id = "nr", Name = "Nauru"},

                        new Country {Id = "np", Name = "Nepal"},

                        new Country {Id = "nl", Name = "Netherlands"},

                        new Country {Id = "an", Name = "Netherlands Antilles"},

                        new Country {Id = "nc", Name = "New Caledonia"},

                        new Country {Id = "nz", Name = "New Zealand"},

                        new Country {Id = "ni", Name = "Nicaragua"},

                        new Country {Id = "ne", Name = "Niger"},

                        new Country {Id = "ng", Name = "Nigeria"},

                        new Country {Id = "nu", Name = "Niue"},

                        new Country {Id = "nf", Name = "Norfolk Island"},

                        new Country {Id = "mp", Name = "Northern Mariana Islands"},

                        new Country {Id = "no", Name = "Norway"},

                        new Country {Id = "om", Name = "Oman"},

                        new Country {Id = "pk", Name = "Pakistan"},

                        new Country {Id = "pw", Name = "Palau"},

                        new Country {Id = "ps", Name = "Palestinian Territory, Occupied"},

                        new Country {Id = "pa", Name = "Panama"},

                        new Country {Id = "pg", Name = "Papua New Guinea"},

                        new Country {Id = "py", Name = "Paraguay"},

                        new Country {Id = "pe", Name = "Peru"},

                        new Country {Id = "ph", Name = "Philippines"},

                        new Country {Id = "pn", Name = "Pitcairn"},

                        new Country {Id = "pl", Name = "Poland"},

                        new Country {Id = "pt", Name = "Portugal"},

                        new Country {Id = "pr", Name = "Puerto Rico"},

                        new Country {Id = "qa", Name = "Qatar"},

                        new Country {Id = "re", Name = "Reunion"},

                        new Country {Id = "ro", Name = "Romania"},

                        new Country {Id = "ru", Name = "Russian Federation"},

                        new Country {Id = "rw", Name = "Rwanda"},

                        new Country {Id = "bl", Name = "Saint Barthelemy"},

                        new Country {Id = "sh", Name = "Saint Helena"},

                        new Country {Id = "kn", Name = "Saint Kitts and Nevis"},

                        new Country {Id = "lc", Name = "Saint Lucia"},

                        new Country {Id = "mf", Name = "Saint Martin"},

                        new Country {Id = "pm", Name = "Saint Pierre and Miquelon"},

                        new Country {Id = "vc", Name = "Saint Vincent and the Grenadines"},

                        new Country {Id = "ws", Name = "Samoa"},

                        new Country {Id = "sm", Name = "San Marino"},

                        new Country {Id = "st", Name = "Sao Tome and Principe"},

                        new Country {Id = "sa", Name = "Saudi Arabia"},

                        new Country {Id = "sn", Name = "Senegal"},

                        new Country {Id = "rs", Name = "Serbia"},

                        new Country {Id = "cs", Name = "Serbia and Montenegro"},

                        new Country {Id = "sc", Name = "Seychelles"},

                        new Country {Id = "sl", Name = "Sierra Leone"},

                        new Country {Id = "sg", Name = "Singapore"},

                        new Country {Id = "sx", Name = "Sint Maarten"},

                        new Country {Id = "sk", Name = "Slovakia"},

                        new Country {Id = "si", Name = "Slovenia"},

                        new Country {Id = "sb", Name = "Solomon Islands"},

                        new Country {Id = "so", Name = "Somalia"},

                        new Country {Id = "za", Name = "South Africa"},

                        new Country {Id = "gs", Name = "South Georgia and the South Sandwich Islands"},

                        new Country {Id = "ss", Name = "South Sudan"},

                        new Country {Id = "es", Name = "Spain"},

                        new Country {Id = "lk", Name = "Sri Lanka"},

                        new Country {Id = "sd", Name = "Sudan"},

                        new Country {Id = "sr", Name = "Suriname"},

                        new Country {Id = "sj", Name = "Svalbard and Jan Mayen"},

                        new Country {Id = "sz", Name = "Swaziland"},

                        new Country {Id = "se", Name = "Sweden"},

                        new Country {Id = "ch", Name = "Switzerland"},

                        new Country {Id = "sy", Name = "Syrian Arab Republic"},

                        new Country {Id = "tw", Name = "Taiwan, Province of China"},

                        new Country {Id = "tj", Name = "Tajikistan"},

                        new Country {Id = "tz", Name = "Tanzania, United Republic of"},

                        new Country {Id = "th", Name = "Thailand"},

                        new Country {Id = "tl", Name = "Timor-Leste"},

                        new Country {Id = "tg", Name = "Togo"},

                        new Country {Id = "tk", Name = "Tokelau"},

                        new Country {Id = "to", Name = "Tonga"},

                        new Country {Id = "tt", Name = "Trinidad and Tobago"},

                        new Country {Id = "tn", Name = "Tunisia"},

                        new Country {Id = "tr", Name = "Turkey"},

                        new Country {Id = "tm", Name = "Turkmenistan"},

                        new Country {Id = "tc", Name = "Turks and Caicos Islands"},

                        new Country {Id = "tv", Name = "Tuvalu"},

                        new Country {Id = "ug", Name = "Uganda"},

                        new Country {Id = "ua", Name = "Ukraine"},

                        new Country {Id = "ae", Name = "United Arab Emirates"},

                        new Country {Id = "gb", Name = "United Kingdom"},

                        new Country {Id = "us", Name = "United States"},

                        new Country {Id = "um", Name = "United States Minor Outlying Islands"},

                        new Country {Id = "uy", Name = "Uruguay"},

                        new Country {Id = "uz", Name = "Uzbekistan"},

                        new Country {Id = "vu", Name = "Vanuatu"},

                        new Country {Id = "ve", Name = "Venezuela"},

                        new Country {Id = "vn", Name = "Viet Nam"},

                        new Country {Id = "vg", Name = "Virgin Islands, British"},

                        new Country {Id = "vi", Name = "Virgin Islands, U.s."},

                        new Country {Id = "wf", Name = "Wallis and Futuna"},

                        new Country {Id = "eh", Name = "Western Sahara"},

                        new Country {Id = "ye", Name = "Yemen"},

                        new Country {Id = "zm", Name = "Zambia"},

                        new Country {Id = "zw", Name = "Zimbabwe"}
                    #endregion
                };
                await context.Countries.AddRangeAsync(countries);
                await context.SaveChangesAsync();
            }
            if(!hasRoles)
            {
                var roles = new IdentityRole[]
                {
                    new IdentityRole{ Id = "RL01", Name = "Reader", NormalizedName = "Reader".ToUpper() },
                    new IdentityRole{ Id = "RL02", Name = "Author", NormalizedName = "Author".ToUpper() },
                    new IdentityRole{ Id = "RL03", Name = "Assitant", NormalizedName = "Assitant".ToUpper() },
                    new IdentityRole{ Id = "RL04", Name = "Admin", NormalizedName = "Admin".ToUpper() }
                };
                await context.Roles.AddRangeAsync(roles);
                await context.SaveChangesAsync();
            }    
        }
    }
}
