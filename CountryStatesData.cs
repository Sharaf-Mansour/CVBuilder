namespace CVBuilder;
public class CountryStatesData
{
    public static CountryState[] CountryStates => [
    new() {
        Country = new() { Id = 1, Name = "Afghanistan", TwoLetterIsoCode = "AF", ThreeLetterIsoCode = "AFG" },
    },
    new() {
        Country = new() { Id = 2, Name = "Åland Islands", TwoLetterIsoCode = "AX", ThreeLetterIsoCode = "ALA" },
    },
    new() {
        Country = new() { Id = 3, Name = "Albania", TwoLetterIsoCode = "AL", ThreeLetterIsoCode = "ALB" },
    },
    new() {
        Country = new() { Id = 4, Name = "Algeria", TwoLetterIsoCode = "DZ", ThreeLetterIsoCode = "DZA" },
    },
    new() {
        Country = new() { Id = 5, Name = "American Samoa", TwoLetterIsoCode = "AS", ThreeLetterIsoCode = "ASM" },
    },
    new() {
        Country = new() { Id = 6, Name = "Andorra", TwoLetterIsoCode = "AD", ThreeLetterIsoCode = "AND" },
    },
    new() {
        Country = new() { Id = 7, Name = "Angola", TwoLetterIsoCode = "AO", ThreeLetterIsoCode = "AGO" },
    },
    new() {
        Country = new() { Id = 8, Name = "Anguilla", TwoLetterIsoCode = "AI", ThreeLetterIsoCode = "AIA" },
    },
    new() {
        Country = new() { Id = 9, Name = "Antarctica", TwoLetterIsoCode = "AQ", ThreeLetterIsoCode = "ATA" },
    },
    new() {
        Country = new() { Id = 10, Name = "Antigua and Barbuda", TwoLetterIsoCode = "AG", ThreeLetterIsoCode = "ATG" },
    },
    new() {
        Country = new() { Id = 11, Name = "Argentina", TwoLetterIsoCode = "AR", ThreeLetterIsoCode = "ARG" },
        StateProvince = [
            new () {
                Id = 12,
                Name = "Ciudad Autonoma de Buenos Aires",
                CountryId = 11
            },
            new () {
                Id = 13,
                Name = "Buenos Aires",
                CountryId = 11
            },
            new () {
                Id = 14,
                Name = "Catamarca",
                CountryId = 11
            },
            new () {
                Id = 15,
                Name = "Chaco",
                CountryId = 11
            },
            new () {
                Id = 16,
                Name = "Chubut",
                CountryId = 11
            },
            new () {
                Id = 17,
                Name = "Cordoba",
                CountryId = 11
            },
            new () {
                Id = 18,
                Name = "Corrientes",
                CountryId = 11
            },
            new () {
                Id = 19,
                Name = "Entre Rios",
                CountryId = 11
            },
            new () {
                Id = 20,
                Name = "Formosa",
                CountryId = 11
            },
            new () {
                Id = 21,
                Name = "Jujuy",
                CountryId = 11
            },
            new () {
                Id = 22,
                Name = "La Pampa",
                CountryId = 11
            },
            new () {
                Id = 23,
                Name = "La Rioja",
                CountryId = 11
            },
            new () {
                Id = 24,
                Name = "Mendoza",
                CountryId = 11
            },
            new () {
                Id = 25,
                Name = "Misiones",
                CountryId = 11
            },
            new () {
                Id = 26,
                Name = "Neuquen",
                CountryId = 11
            },
            new () {
                Id = 27,
                Name = "Rio Negro",
                CountryId = 11
            },
            new () {
                Id = 28,
                Name = "Salta",
                CountryId = 11
            },
            new () {
                Id = 29,
                Name = "San Juan",
                CountryId = 11
            },
            new () {
                Id = 30,
                Name = "San Luis",
                CountryId = 11
            },
            new () {
                Id = 31,
                Name = "Santa Cruz",
                CountryId = 11
            },
            new () {
                Id = 32,
                Name = "Santa Fe",
                CountryId = 11
            },
            new () {
                Id = 33,
                Name = "Santiago del Estero",
                CountryId = 11
            },
            new () {
                Id = 34,
                Name = "Tierra del Fuego",
                CountryId = 11
            },
            new () {
                Id = 35,
                Name = "Tucuman",
                CountryId = 11
            },
        ]
    },
    new() {
        Country = new() { Id = 12, Name = "Armenia", TwoLetterIsoCode = "AM", ThreeLetterIsoCode = "ARM" },
        StateProvince = [
            new () {
                Id = 1,
                Name = "Երևան",
                CountryId = 12
            },
            new () {
                Id = 2,
                Name = "Արարատի մարզ",
                CountryId = 12
            },
            new () {
                Id = 3,
                Name = "Արմավիրի մարզ",
                CountryId = 12
            },
            new () {
                Id = 4,
                Name = "Կոտայքի մարզ",
                CountryId = 12
            },
            new () {
                Id = 5,
                Name = "Արագածոտնի մարտ",
                CountryId = 12
            },
            new () {
                Id = 6,
                Name = "Գեղարքունիքի մարզ",
                CountryId = 12
            },
            new () {
                Id = 7,
                Name = "Շիրակի մարզ",
                CountryId = 12
            },
            new () {
                Id = 8,
                Name = "Լոռու մարզ",
                CountryId = 12
            },
            new () {
                Id = 9,
                Name = "Վայոց ձորի մարզ",
                CountryId = 12
            },
            new () {
                Id = 10,
                Name = "Սյունիքի մարզ",
                CountryId = 12
            },
            new () {
                Id = 11,
                Name = "Տավուշի մարզ",
                CountryId = 12
            },
        ]
    },
    new() {
        Country = new() { Id = 13, Name = "Aruba", TwoLetterIsoCode = "AW", ThreeLetterIsoCode = "ABW" },
    },
    new() {
        Country = new() { Id = 14, Name = "Australia", TwoLetterIsoCode = "AU", ThreeLetterIsoCode = "AUS" },
        StateProvince = [
            new () {
                Id = 45,
                Name = "Australian Capital Territory",
                CountryId = 14
            },
            new () {
                Id = 46,
                Name = "New South Wales",
                CountryId = 14
            },
            new () {
                Id = 47,
                Name = "Northern Territory",
                CountryId = 14
            },
            new () {
                Id = 48,
                Name = "Queensland",
                CountryId = 14
            },
            new () {
                Id = 49,
                Name = "South Australia",
                CountryId = 14
            },
            new () {
                Id = 50,
                Name = "Tasmania",
                CountryId = 14
            },
            new () {
                Id = 51,
                Name = "Victoria",
                CountryId = 14
            },
            new () {
                Id = 52,
                Name = "Western Australia",
                CountryId = 14
            },
        ]
    },
    new() {
        Country = new() { Id = 15, Name = "Austria", TwoLetterIsoCode = "AT", ThreeLetterIsoCode = "AUT" },
        StateProvince = [
            new () {
                Id = 36,
                Name = "Wien",
                CountryId = 15
            },
            new () {
                Id = 37,
                Name = "Niederösterreich",
                CountryId = 15
            },
            new () {
                Id = 38,
                Name = "Oberösterreich",
                CountryId = 15
            },
            new () {
                Id = 39,
                Name = "Salzburg",
                CountryId = 15
            },
            new () {
                Id = 40,
                Name = "Tirol",
                CountryId = 15
            },
            new () {
                Id = 41,
                Name = "Vorarlberg",
                CountryId = 15
            },
            new () {
                Id = 42,
                Name = "Burgenland",
                CountryId = 15
            },
            new () {
                Id = 43,
                Name = "Steiermark",
                CountryId = 15
            },
            new () {
                Id = 44,
                Name = "Kärnten",
                CountryId = 15
            },
        ]
    },
    new() {
        Country = new() { Id = 16, Name = "Azerbaijan", TwoLetterIsoCode = "AZ", ThreeLetterIsoCode = "AZE" },
    },
    new() {
        Country = new() { Id = 17, Name = "Bahamas", TwoLetterIsoCode = "BS", ThreeLetterIsoCode = "BHS" },
    },
    new() {
        Country = new() { Id = 18, Name = "Bahrain", TwoLetterIsoCode = "BH", ThreeLetterIsoCode = "BHR" },
    },
    new() {
        Country = new() { Id = 19, Name = "Bangladesh", TwoLetterIsoCode = "BD", ThreeLetterIsoCode = "BGD" },
        StateProvince = [
            new () {
                Id = 53,
                Name = "বরগুনা",
                CountryId = 19
            },
            new () {
                Id = 54,
                Name = "বরিশাল",
                CountryId = 19
            },
            new () {
                Id = 55,
                Name = "ভোলা",
                CountryId = 19
            },
            new () {
                Id = 56,
                Name = "ঝালকাঠি",
                CountryId = 19
            },
            new () {
                Id = 57,
                Name = "পটুয়াখালী",
                CountryId = 19
            },
            new () {
                Id = 58,
                Name = "পিরোজপুর",
                CountryId = 19
            },
            new () {
                Id = 59,
                Name = "বান্দরবান",
                CountryId = 19
            },
            new () {
                Id = 60,
                Name = "ব্রাহ্মণবাড়ীয়া",
                CountryId = 19
            },
            new () {
                Id = 61,
                Name = "চাঁদপুর",
                CountryId = 19
            },
            new () {
                Id = 62,
                Name = "চট্টগ্রাম",
                CountryId = 19
            },
            new () {
                Id = 63,
                Name = "কুমিল্লা",
                CountryId = 19
            },
            new () {
                Id = 64,
                Name = "কক্সবাজার",
                CountryId = 19
            },
            new () {
                Id = 65,
                Name = "ফেনী",
                CountryId = 19
            },
            new () {
                Id = 66,
                Name = "খাগড়াছড়ি",
                CountryId = 19
            },
            new () {
                Id = 67,
                Name = "লক্ষ্মীপুর",
                CountryId = 19
            },
            new () {
                Id = 68,
                Name = "নোয়াখালী",
                CountryId = 19
            },
            new () {
                Id = 69,
                Name = "রাঙ্গামাটি",
                CountryId = 19
            },
            new () {
                Id = 70,
                Name = "ঢাকা",
                CountryId = 19
            },
            new () {
                Id = 71,
                Name = "ফরিদপুর",
                CountryId = 19
            },
            new () {
                Id = 72,
                Name = "গাজীপুর",
                CountryId = 19
            },
            new () {
                Id = 73,
                Name = "গোপালগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 74,
                Name = "কিশোরগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 75,
                Name = "মাদারীপুর",
                CountryId = 19
            },
            new () {
                Id = 76,
                Name = "মানিকগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 77,
                Name = "মুন্সীগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 78,
                Name = "নারায়ণগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 79,
                Name = "নরসিংদী",
                CountryId = 19
            },
            new () {
                Id = 80,
                Name = "রাজবাড়ী",
                CountryId = 19
            },
            new () {
                Id = 81,
                Name = "শরীয়তপুর",
                CountryId = 19
            },
            new () {
                Id = 82,
                Name = "টাঙ্গাইল",
                CountryId = 19
            },
            new () {
                Id = 83,
                Name = "বাগেরহাট",
                CountryId = 19
            },
            new () {
                Id = 84,
                Name = "চুয়াডাঙ্গা",
                CountryId = 19
            },
            new () {
                Id = 85,
                Name = "যশোর",
                CountryId = 19
            },
            new () {
                Id = 86,
                Name = "ঝিনাইদহ",
                CountryId = 19
            },
            new () {
                Id = 87,
                Name = "খুলনা",
                CountryId = 19
            },
            new () {
                Id = 88,
                Name = "কুষ্টিয়া",
                CountryId = 19
            },
            new () {
                Id = 89,
                Name = "মাগুরা",
                CountryId = 19
            },
            new () {
                Id = 90,
                Name = "মেহেরপুর",
                CountryId = 19
            },
            new () {
                Id = 91,
                Name = "নড়াইল",
                CountryId = 19
            },
            new () {
                Id = 92,
                Name = "সাতক্ষিরা",
                CountryId = 19
            },
            new () {
                Id = 93,
                Name = "জামালপুর",
                CountryId = 19
            },
            new () {
                Id = 94,
                Name = "ময়মনসিংহ",
                CountryId = 19
            },
            new () {
                Id = 95,
                Name = "নেত্রকোনা",
                CountryId = 19
            },
            new () {
                Id = 96,
                Name = "শেরপুর",
                CountryId = 19
            },
            new () {
                Id = 97,
                Name = "বগুড়া",
                CountryId = 19
            },
            new () {
                Id = 98,
                Name = "জয়পুরহাট",
                CountryId = 19
            },
            new () {
                Id = 99,
                Name = "নওগাঁ",
                CountryId = 19
            },
            new () {
                Id = 100,
                Name = "নাটোর",
                CountryId = 19
            },
            new () {
                Id = 101,
                Name = "চাঁপাই নবাবগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 102,
                Name = "পাবনা",
                CountryId = 19
            },
            new () {
                Id = 103,
                Name = "রাজশাহী",
                CountryId = 19
            },
            new () {
                Id = 104,
                Name = "সিরাজগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 105,
                Name = "দিনাজপুর",
                CountryId = 19
            },
            new () {
                Id = 106,
                Name = "গাইবান্ধা",
                CountryId = 19
            },
            new () {
                Id = 107,
                Name = "কুড়িগ্রাম",
                CountryId = 19
            },
            new () {
                Id = 108,
                Name = "লালমনিরহাট",
                CountryId = 19
            },
            new () {
                Id = 109,
                Name = "নীলফামারী",
                CountryId = 19
            },
            new () {
                Id = 110,
                Name = "পঞ্চগড়",
                CountryId = 19
            },
            new () {
                Id = 111,
                Name = "রংপুর",
                CountryId = 19
            },
            new () {
                Id = 112,
                Name = "ঠাকুরগাঁও",
                CountryId = 19
            },
            new () {
                Id = 113,
                Name = "হবিগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 114,
                Name = "মৌলভীবাজার",
                CountryId = 19
            },
            new () {
                Id = 115,
                Name = "সুনামগঞ্জ",
                CountryId = 19
            },
            new () {
                Id = 116,
                Name = "সিলেট",
                CountryId = 19
            },
        ]
    },
    new() {
        Country = new() { Id = 20, Name = "Barbados", TwoLetterIsoCode = "BB", ThreeLetterIsoCode = "BRB" },
    },
    new() {
        Country = new() { Id = 21, Name = "Belarus", TwoLetterIsoCode = "BY", ThreeLetterIsoCode = "BLR" },
        StateProvince = [
            new () {
                Id = 186,
                Name = "Брестская область",
                CountryId = 21
            },
            new () {
                Id = 187,
                Name = "Витебская область",
                CountryId = 21
            },
            new () {
                Id = 188,
                Name = "Гомельская область",
                CountryId = 21
            },
            new () {
                Id = 189,
                Name = "Гродненская область",
                CountryId = 21
            },
            new () {
                Id = 190,
                Name = "Минская область",
                CountryId = 21
            },
            new () {
                Id = 191,
                Name = "Могилёвская область",
                CountryId = 21
            },
            new () {
                Id = 192,
                Name = "Минск",
                CountryId = 21
            },
        ]
    },
    new() {
        Country = new() { Id = 22, Name = "Belgium", TwoLetterIsoCode = "BE", ThreeLetterIsoCode = "BEL" },
        StateProvince = [
            new () {
                Id = 117,
                Name = "Antwerpen",
                CountryId = 22
            },
            new () {
                Id = 118,
                Name = "Brabant wallon",
                CountryId = 22
            },
            new () {
                Id = 119,
                Name = "Hainaut",
                CountryId = 22
            },
            new () {
                Id = 120,
                Name = "Liège",
                CountryId = 22
            },
            new () {
                Id = 121,
                Name = "Limburg",
                CountryId = 22
            },
            new () {
                Id = 122,
                Name = "Luxembourg",
                CountryId = 22
            },
            new () {
                Id = 123,
                Name = "Namur",
                CountryId = 22
            },
            new () {
                Id = 124,
                Name = "Oost-Vlaanderen",
                CountryId = 22
            },
            new () {
                Id = 125,
                Name = "Vlaams-Brabant",
                CountryId = 22
            },
            new () {
                Id = 126,
                Name = "West-Vlaanderen",
                CountryId = 22
            },
        ]
    },
    new() {
        Country = new() { Id = 23, Name = "Belize", TwoLetterIsoCode = "BZ", ThreeLetterIsoCode = "BLZ" },
    },
    new() {
        Country = new() { Id = 24, Name = "Benin", TwoLetterIsoCode = "BJ", ThreeLetterIsoCode = "BEN" },
    },
    new() {
        Country = new() { Id = 25, Name = "Bermuda", TwoLetterIsoCode = "BM", ThreeLetterIsoCode = "BMU" },
    },
    new() {
        Country = new() { Id = 26, Name = "Bhutan", TwoLetterIsoCode = "BT", ThreeLetterIsoCode = "BTN" },
    },
    new() {
        Country = new() { Id = 27, Name = "Bolivia (Plurinational State of)", TwoLetterIsoCode = "BO", ThreeLetterIsoCode = "BOL" },
    },
    new() {
        Country = new() { Id = 28, Name = "Bonaire, Sint Eustatius and Saba", TwoLetterIsoCode = "BQ", ThreeLetterIsoCode = "BES" },
    },
    new() {
        Country = new() { Id = 29, Name = "Bosnia and Herzegovina", TwoLetterIsoCode = "BA", ThreeLetterIsoCode = "BIH" },
    },
    new() {
        Country = new() { Id = 30, Name = "Botswana", TwoLetterIsoCode = "BW", ThreeLetterIsoCode = "BWA" },
    },
    new() {
        Country = new() { Id = 31, Name = "Bouvet Island", TwoLetterIsoCode = "BV", ThreeLetterIsoCode = "BVT" },
    },
    new() {
        Country = new() { Id = 32, Name = "Brazil", TwoLetterIsoCode = "BR", ThreeLetterIsoCode = "BRA" },
        StateProvince = [
            new () {
                Id = 159,
                Name = "Acre",
                CountryId = 32
            },
            new () {
                Id = 160,
                Name = "Alagoas",
                CountryId = 32
            },
            new () {
                Id = 161,
                Name = "Amapá",
                CountryId = 32
            },
            new () {
                Id = 162,
                Name = "Amazonas",
                CountryId = 32
            },
            new () {
                Id = 163,
                Name = "Bahia",
                CountryId = 32
            },
            new () {
                Id = 164,
                Name = "Ceará",
                CountryId = 32
            },
            new () {
                Id = 165,
                Name = "Distrito Federal",
                CountryId = 32
            },
            new () {
                Id = 166,
                Name = "Espírito Santo",
                CountryId = 32
            },
            new () {
                Id = 167,
                Name = "Goiás",
                CountryId = 32
            },
            new () {
                Id = 168,
                Name = "Maranhão",
                CountryId = 32
            },
            new () {
                Id = 169,
                Name = "Mato Grosso",
                CountryId = 32
            },
            new () {
                Id = 170,
                Name = "Mato Grosso do Sul",
                CountryId = 32
            },
            new () {
                Id = 171,
                Name = "Minas Gerais",
                CountryId = 32
            },
            new () {
                Id = 172,
                Name = "Pará",
                CountryId = 32
            },
            new () {
                Id = 173,
                Name = "Paraíba",
                CountryId = 32
            },
            new () {
                Id = 174,
                Name = "Paraná",
                CountryId = 32
            },
            new () {
                Id = 175,
                Name = "Pernambuco",
                CountryId = 32
            },
            new () {
                Id = 176,
                Name = "Piauí",
                CountryId = 32
            },
            new () {
                Id = 177,
                Name = "Rio de Janeiro",
                CountryId = 32
            },
            new () {
                Id = 178,
                Name = "Rio Grande do Norte",
                CountryId = 32
            },
            new () {
                Id = 179,
                Name = "Rio Grande do Sul",
                CountryId = 32
            },
            new () {
                Id = 180,
                Name = "Rondônia",
                CountryId = 32
            },
            new () {
                Id = 181,
                Name = "Roraima",
                CountryId = 32
            },
            new () {
                Id = 182,
                Name = "Santa Catarina",
                CountryId = 32
            },
            new () {
                Id = 183,
                Name = "São Paulo",
                CountryId = 32
            },
            new () {
                Id = 184,
                Name = "Sergipe",
                CountryId = 32
            },
            new () {
                Id = 185,
                Name = "Tocantins",
                CountryId = 32
            },
        ]
    },
    new() {
        Country = new() { Id = 33, Name = "British Indian Ocean Territory", TwoLetterIsoCode = "IO", ThreeLetterIsoCode = "IOT" },
    },
    new() {
        Country = new() { Id = 34, Name = "Brunei Darussalam", TwoLetterIsoCode = "BN", ThreeLetterIsoCode = "BRN" },
        StateProvince = [
            new () {
                Id = 155,
                Name = "Belait",
                CountryId = 34
            },
            new () {
                Id = 156,
                Name = "Brunei-Muara",
                CountryId = 34
            },
            new () {
                Id = 157,
                Name = "Temburong",
                CountryId = 34
            },
            new () {
                Id = 158,
                Name = "Tutong",
                CountryId = 34
            },
        ]
    },
    new() {
        Country = new() { Id = 35, Name = "Bulgaria", TwoLetterIsoCode = "BG", ThreeLetterIsoCode = "BGR" },
        StateProvince = [
            new () {
                Id = 127,
                Name = "Blagoevgrad",
                CountryId = 35
            },
            new () {
                Id = 128,
                Name = "Burgas",
                CountryId = 35
            },
            new () {
                Id = 129,
                Name = "Dobrich",
                CountryId = 35
            },
            new () {
                Id = 130,
                Name = "Gabrovo",
                CountryId = 35
            },
            new () {
                Id = 131,
                Name = "Haskovo",
                CountryId = 35
            },
            new () {
                Id = 132,
                Name = "Kardzhali",
                CountryId = 35
            },
            new () {
                Id = 133,
                Name = "Kyustendil",
                CountryId = 35
            },
            new () {
                Id = 134,
                Name = "Lovech",
                CountryId = 35
            },
            new () {
                Id = 135,
                Name = "Montana",
                CountryId = 35
            },
            new () {
                Id = 136,
                Name = "Pazardzhik",
                CountryId = 35
            },
            new () {
                Id = 137,
                Name = "Pernik",
                CountryId = 35
            },
            new () {
                Id = 138,
                Name = "Pleven",
                CountryId = 35
            },
            new () {
                Id = 139,
                Name = "Plovdiv",
                CountryId = 35
            },
            new () {
                Id = 140,
                Name = "Razgrad",
                CountryId = 35
            },
            new () {
                Id = 141,
                Name = "Ruse",
                CountryId = 35
            },
            new () {
                Id = 142,
                Name = "Shumen",
                CountryId = 35
            },
            new () {
                Id = 143,
                Name = "Silistra",
                CountryId = 35
            },
            new () {
                Id = 144,
                Name = "Sliven",
                CountryId = 35
            },
            new () {
                Id = 145,
                Name = "Smolyan",
                CountryId = 35
            },
            new () {
                Id = 146,
                Name = "Sofia",
                CountryId = 35
            },
            new () {
                Id = 147,
                Name = "Sofia city",
                CountryId = 35
            },
            new () {
                Id = 148,
                Name = "Stara Zagora",
                CountryId = 35
            },
            new () {
                Id = 149,
                Name = "Targovishte",
                CountryId = 35
            },
            new () {
                Id = 150,
                Name = "Varna",
                CountryId = 35
            },
            new () {
                Id = 151,
                Name = "Veliko Tarnovo",
                CountryId = 35
            },
            new () {
                Id = 152,
                Name = "Vidin",
                CountryId = 35
            },
            new () {
                Id = 153,
                Name = "Vratsa",
                CountryId = 35
            },
            new () {
                Id = 154,
                Name = "Yambol",
                CountryId = 35
            },
        ]
    },
    new() {
        Country = new() { Id = 36, Name = "Burkina Faso", TwoLetterIsoCode = "BF", ThreeLetterIsoCode = "BFA" },
    },
    new() {
        Country = new() { Id = 37, Name = "Burundi", TwoLetterIsoCode = "BI", ThreeLetterIsoCode = "BDI" },
    },
    new() {
        Country = new() { Id = 38, Name = "Cabo Verde", TwoLetterIsoCode = "CV", ThreeLetterIsoCode = "CPV" },
    },
    new() {
        Country = new() { Id = 39, Name = "Cambodia", TwoLetterIsoCode = "KH", ThreeLetterIsoCode = "KHM" },
    },
    new() {
        Country = new() { Id = 40, Name = "Cameroon", TwoLetterIsoCode = "CM", ThreeLetterIsoCode = "CMR" },
    },
    new() {
        Country = new() { Id = 41, Name = "Canada", TwoLetterIsoCode = "CA", ThreeLetterIsoCode = "CAN" },
        StateProvince = [
            new () {
                Id = 193,
                Name = "Alberta",
                CountryId = 41
            },
            new () {
                Id = 194,
                Name = "British Columbia",
                CountryId = 41
            },
            new () {
                Id = 195,
                Name = "Manitoba",
                CountryId = 41
            },
            new () {
                Id = 196,
                Name = "New Brunswick",
                CountryId = 41
            },
            new () {
                Id = 197,
                Name = "Newfoundland and Labrador",
                CountryId = 41
            },
            new () {
                Id = 198,
                Name = "Northwest Territories",
                CountryId = 41
            },
            new () {
                Id = 199,
                Name = "Nova Scotia",
                CountryId = 41
            },
            new () {
                Id = 200,
                Name = "Nunavut",
                CountryId = 41
            },
            new () {
                Id = 201,
                Name = "Ontario",
                CountryId = 41
            },
            new () {
                Id = 202,
                Name = "Prince Edward Island",
                CountryId = 41
            },
            new () {
                Id = 203,
                Name = "Quebec",
                CountryId = 41
            },
            new () {
                Id = 204,
                Name = "Saskatchewan",
                CountryId = 41
            },
            new () {
                Id = 205,
                Name = "Yukon Territory",
                CountryId = 41
            },
        ]
    },
    new() {
        Country = new() { Id = 42, Name = "Cayman Islands", TwoLetterIsoCode = "KY", ThreeLetterIsoCode = "CYM" },
    },
    new() {
        Country = new() { Id = 43, Name = "Central African Republic", TwoLetterIsoCode = "CF", ThreeLetterIsoCode = "CAF" },
    },
    new() {
        Country = new() { Id = 44, Name = "Chad", TwoLetterIsoCode = "TD", ThreeLetterIsoCode = "TCD" },
    },
    new() {
        Country = new() { Id = 45, Name = "Chile", TwoLetterIsoCode = "CL", ThreeLetterIsoCode = "CHL" },
    },
    new() {
        Country = new() { Id = 46, Name = "China", TwoLetterIsoCode = "CN", ThreeLetterIsoCode = "CHN" },
        StateProvince = [
            new () {
                Id = 232,
                Name = "北京市",
                CountryId = 46
            },
            new () {
                Id = 233,
                Name = "天津市",
                CountryId = 46
            },
            new () {
                Id = 234,
                Name = "河北省",
                CountryId = 46
            },
            new () {
                Id = 235,
                Name = "山西省",
                CountryId = 46
            },
            new () {
                Id = 236,
                Name = "内蒙古自治区",
                CountryId = 46
            },
            new () {
                Id = 237,
                Name = "辽宁省",
                CountryId = 46
            },
            new () {
                Id = 238,
                Name = "吉林省",
                CountryId = 46
            },
            new () {
                Id = 239,
                Name = "黑龙江省",
                CountryId = 46
            },
            new () {
                Id = 240,
                Name = "上海市",
                CountryId = 46
            },
            new () {
                Id = 241,
                Name = "江苏省",
                CountryId = 46
            },
            new () {
                Id = 242,
                Name = "浙江省",
                CountryId = 46
            },
            new () {
                Id = 243,
                Name = "安徽省",
                CountryId = 46
            },
            new () {
                Id = 244,
                Name = "福建省",
                CountryId = 46
            },
            new () {
                Id = 245,
                Name = "江西省",
                CountryId = 46
            },
            new () {
                Id = 246,
                Name = "山东省",
                CountryId = 46
            },
            new () {
                Id = 247,
                Name = "河南省",
                CountryId = 46
            },
            new () {
                Id = 248,
                Name = "湖北省",
                CountryId = 46
            },
            new () {
                Id = 249,
                Name = "湖南省",
                CountryId = 46
            },
            new () {
                Id = 250,
                Name = "广东省",
                CountryId = 46
            },
            new () {
                Id = 251,
                Name = "广西壮族自治区",
                CountryId = 46
            },
            new () {
                Id = 252,
                Name = "海南省",
                CountryId = 46
            },
            new () {
                Id = 253,
                Name = "重庆市",
                CountryId = 46
            },
            new () {
                Id = 254,
                Name = "四川省",
                CountryId = 46
            },
            new () {
                Id = 255,
                Name = "贵州省",
                CountryId = 46
            },
            new () {
                Id = 256,
                Name = "云南省",
                CountryId = 46
            },
            new () {
                Id = 257,
                Name = "西藏自治区",
                CountryId = 46
            },
            new () {
                Id = 258,
                Name = "陕西省",
                CountryId = 46
            },
            new () {
                Id = 259,
                Name = "甘肃省",
                CountryId = 46
            },
            new () {
                Id = 260,
                Name = "青海省",
                CountryId = 46
            },
            new () {
                Id = 261,
                Name = "宁夏回族自治区",
                CountryId = 46
            },
            new () {
                Id = 262,
                Name = "新疆维吾尔自治区",
                CountryId = 46
            },
            new () {
                Id = 263,
                Name = "香港特别行政区",
                CountryId = 46
            },
            new () {
                Id = 264,
                Name = "澳门特别行政区",
                CountryId = 46
            },
            new () {
                Id = 265,
                Name = "台湾省",
                CountryId = 46
            },
        ]
    },
    new() {
        Country = new() { Id = 47, Name = "Christmas Island", TwoLetterIsoCode = "CX", ThreeLetterIsoCode = "CXR" },
    },
    new() {
        Country = new() { Id = 48, Name = "Cocos (Keeling) Islands", TwoLetterIsoCode = "CC", ThreeLetterIsoCode = "CCK" },
    },
    new() {
        Country = new() { Id = 49, Name = "Colombia", TwoLetterIsoCode = "CO", ThreeLetterIsoCode = "COL" },
        StateProvince = [
            new () {
                Id = 266,
                Name = "Amazonas",
                CountryId = 49
            },
            new () {
                Id = 267,
                Name = "Antioquia",
                CountryId = 49
            },
            new () {
                Id = 268,
                Name = "Arauca",
                CountryId = 49
            },
            new () {
                Id = 269,
                Name = "Atlántico",
                CountryId = 49
            },
            new () {
                Id = 270,
                Name = "Bolívar",
                CountryId = 49
            },
            new () {
                Id = 271,
                Name = "Boyacá",
                CountryId = 49
            },
            new () {
                Id = 272,
                Name = "Caldas",
                CountryId = 49
            },
            new () {
                Id = 273,
                Name = "Caquetá",
                CountryId = 49
            },
            new () {
                Id = 274,
                Name = "Casanare",
                CountryId = 49
            },
            new () {
                Id = 275,
                Name = "Cauca",
                CountryId = 49
            },
            new () {
                Id = 276,
                Name = "Cesar",
                CountryId = 49
            },
            new () {
                Id = 277,
                Name = "Chocó",
                CountryId = 49
            },
            new () {
                Id = 278,
                Name = "Córdoba",
                CountryId = 49
            },
            new () {
                Id = 279,
                Name = "Cundinamarca",
                CountryId = 49
            },
            new () {
                Id = 280,
                Name = "Guainía",
                CountryId = 49
            },
            new () {
                Id = 281,
                Name = "Guaviare",
                CountryId = 49
            },
            new () {
                Id = 282,
                Name = "Huila",
                CountryId = 49
            },
            new () {
                Id = 283,
                Name = "La Guajira",
                CountryId = 49
            },
            new () {
                Id = 284,
                Name = "Magdalena",
                CountryId = 49
            },
            new () {
                Id = 285,
                Name = "Meta",
                CountryId = 49
            },
            new () {
                Id = 286,
                Name = "Nariño",
                CountryId = 49
            },
            new () {
                Id = 287,
                Name = "Norte de Santander",
                CountryId = 49
            },
            new () {
                Id = 288,
                Name = "Putumayo",
                CountryId = 49
            },
            new () {
                Id = 289,
                Name = "Quindío",
                CountryId = 49
            },
            new () {
                Id = 290,
                Name = "Risaralda",
                CountryId = 49
            },
            new () {
                Id = 291,
                Name = "San Andrés y Providencia",
                CountryId = 49
            },
            new () {
                Id = 292,
                Name = "Santander",
                CountryId = 49
            },
            new () {
                Id = 293,
                Name = "Sucre",
                CountryId = 49
            },
            new () {
                Id = 294,
                Name = "Tolima",
                CountryId = 49
            },
            new () {
                Id = 295,
                Name = "Valle del Cauca",
                CountryId = 49
            },
            new () {
                Id = 296,
                Name = "Vaupés",
                CountryId = 49
            },
            new () {
                Id = 297,
                Name = "Vichada",
                CountryId = 49
            },
        ]
    },
    new() {
        Country = new() { Id = 50, Name = "Comoros", TwoLetterIsoCode = "KM", ThreeLetterIsoCode = "COM" },
    },
    new() {
        Country = new() { Id = 51, Name = "Congo", TwoLetterIsoCode = "CG", ThreeLetterIsoCode = "COG" },
    },
    new() {
        Country = new() { Id = 52, Name = "Congo (Democratic Republic of the)", TwoLetterIsoCode = "CD", ThreeLetterIsoCode = "COD" },
    },
    new() {
        Country = new() { Id = 53, Name = "Cook Islands", TwoLetterIsoCode = "CK", ThreeLetterIsoCode = "COK" },
    },
    new() {
        Country = new() { Id = 54, Name = "Costa Rica", TwoLetterIsoCode = "CR", ThreeLetterIsoCode = "CRI" },
        StateProvince = [
            new () {
                Id = 298,
                Name = "Alajuela",
                CountryId = 54
            },
            new () {
                Id = 299,
                Name = "Cartago",
                CountryId = 54
            },
            new () {
                Id = 300,
                Name = "Guanacaste",
                CountryId = 54
            },
            new () {
                Id = 301,
                Name = "Heredia",
                CountryId = 54
            },
            new () {
                Id = 302,
                Name = "Limón",
                CountryId = 54
            },
            new () {
                Id = 303,
                Name = "Puntarenas",
                CountryId = 54
            },
            new () {
                Id = 304,
                Name = "San José",
                CountryId = 54
            },
        ]
    },
    new() {
        Country = new() { Id = 55, Name = "Côte d'Ivoire", TwoLetterIsoCode = "CI", ThreeLetterIsoCode = "CIV" },
    },
    new() {
        Country = new() { Id = 56, Name = "Croatia", TwoLetterIsoCode = "HR", ThreeLetterIsoCode = "HRV" },
        StateProvince = [
            new () {
                Id = 733,
                Name = "Grad Zagreb",
                CountryId = 56
            },
            new () {
                Id = 734,
                Name = "Bjelovarsko-bilogorska",
                CountryId = 56
            },
            new () {
                Id = 735,
                Name = "Brodsko-posavska",
                CountryId = 56
            },
            new () {
                Id = 736,
                Name = "Dubrovačko-neretvanska",
                CountryId = 56
            },
            new () {
                Id = 737,
                Name = "Istarska",
                CountryId = 56
            },
            new () {
                Id = 738,
                Name = "Karlovačka",
                CountryId = 56
            },
            new () {
                Id = 739,
                Name = "Koprivničko-križevačka",
                CountryId = 56
            },
            new () {
                Id = 740,
                Name = "Krapinsko-zagorska",
                CountryId = 56
            },
            new () {
                Id = 741,
                Name = "Ličko-senjska",
                CountryId = 56
            },
            new () {
                Id = 742,
                Name = "Međimurska",
                CountryId = 56
            },
            new () {
                Id = 743,
                Name = "Osječko-baranjska",
                CountryId = 56
            },
            new () {
                Id = 744,
                Name = "Požeško-slavonska",
                CountryId = 56
            },
            new () {
                Id = 745,
                Name = "Primorsko-goranska",
                CountryId = 56
            },
            new () {
                Id = 746,
                Name = "Sisačko-moslavačka",
                CountryId = 56
            },
            new () {
                Id = 747,
                Name = "Splitsko-dalmatinska",
                CountryId = 56
            },
            new () {
                Id = 748,
                Name = "Šibensko-kninska",
                CountryId = 56
            },
            new () {
                Id = 749,
                Name = "Varaždinska",
                CountryId = 56
            },
            new () {
                Id = 750,
                Name = "Virovitičko-podravska",
                CountryId = 56
            },
            new () {
                Id = 751,
                Name = "Vukovarsko-srijemska",
                CountryId = 56
            },
            new () {
                Id = 752,
                Name = "Zadarska",
                CountryId = 56
            },
            new () {
                Id = 753,
                Name = "Zagrebačka",
                CountryId = 56
            },
        ]
    },
    new() {
        Country = new() { Id = 57, Name = "Cuba", TwoLetterIsoCode = "CU", ThreeLetterIsoCode = "CUB" },
        StateProvince = [
            new () {
                Id = 305,
                Name = "Pinar del Río",
                CountryId = 57
            },
            new () {
                Id = 306,
                Name = "Artemisa",
                CountryId = 57
            },
            new () {
                Id = 307,
                Name = "La Habana",
                CountryId = 57
            },
            new () {
                Id = 308,
                Name = "Mayabeque",
                CountryId = 57
            },
            new () {
                Id = 309,
                Name = "Matanzas",
                CountryId = 57
            },
            new () {
                Id = 310,
                Name = "Cienfuegos",
                CountryId = 57
            },
            new () {
                Id = 311,
                Name = "Villa Clara",
                CountryId = 57
            },
            new () {
                Id = 312,
                Name = "Sancti Spíritus",
                CountryId = 57
            },
            new () {
                Id = 313,
                Name = "Ciego de Ávila",
                CountryId = 57
            },
            new () {
                Id = 314,
                Name = "Camagüey",
                CountryId = 57
            },
            new () {
                Id = 315,
                Name = "Las Tunas",
                CountryId = 57
            },
            new () {
                Id = 316,
                Name = "Holguín",
                CountryId = 57
            },
            new () {
                Id = 317,
                Name = "Granma",
                CountryId = 57
            },
            new () {
                Id = 318,
                Name = "Santiago de Cuba",
                CountryId = 57
            },
            new () {
                Id = 319,
                Name = "Guantánamo",
                CountryId = 57
            },
            new () {
                Id = 320,
                Name = "Isla de la Juventud",
                CountryId = 57
            },
        ]
    },
    new() {
        Country = new() { Id = 58, Name = "Curaçao", TwoLetterIsoCode = "CW", ThreeLetterIsoCode = "CUW" },
    },
    new() {
        Country = new() { Id = 59, Name = "Cyprus", TwoLetterIsoCode = "CY", ThreeLetterIsoCode = "CYP" },
        StateProvince = [
            new () {
                Id = 321,
                Name = "Famagusta district",
                CountryId = 59
            },
            new () {
                Id = 322,
                Name = "Kyrenia district",
                CountryId = 59
            },
            new () {
                Id = 323,
                Name = "Limassol district",
                CountryId = 59
            },
            new () {
                Id = 324,
                Name = "Larnaca district",
                CountryId = 59
            },
            new () {
                Id = 325,
                Name = "Nicosia district",
                CountryId = 59
            },
            new () {
                Id = 326,
                Name = "Paphos district",
                CountryId = 59
            },
        ]
    },
    new() {
        Country = new() { Id = 60, Name = "Czechia", TwoLetterIsoCode = "CZ", ThreeLetterIsoCode = "CZE" },
        StateProvince = [
            new () {
                Id = 327,
                Name = "Hlavní město Praha",
                CountryId = 60
            },
            new () {
                Id = 328,
                Name = "Středočeský kraj",
                CountryId = 60
            },
            new () {
                Id = 329,
                Name = "Jihočeský kraj",
                CountryId = 60
            },
            new () {
                Id = 330,
                Name = "Plzeňský kraj",
                CountryId = 60
            },
            new () {
                Id = 331,
                Name = "Karlovarský kraj",
                CountryId = 60
            },
            new () {
                Id = 332,
                Name = "Ústecký kraj",
                CountryId = 60
            },
            new () {
                Id = 333,
                Name = "Liberecký kraj",
                CountryId = 60
            },
            new () {
                Id = 334,
                Name = "Královéhradecký kraj",
                CountryId = 60
            },
            new () {
                Id = 335,
                Name = "Pardubický kraj",
                CountryId = 60
            },
            new () {
                Id = 336,
                Name = "Kraj Vysočina",
                CountryId = 60
            },
            new () {
                Id = 337,
                Name = "Jihomoravský kraj",
                CountryId = 60
            },
            new () {
                Id = 338,
                Name = "Olomoucký kraj",
                CountryId = 60
            },
            new () {
                Id = 339,
                Name = "Zlínský kraj",
                CountryId = 60
            },
            new () {
                Id = 340,
                Name = "Moravskoslezský kraj",
                CountryId = 60
            },
        ]
    },
    new() {
        Country = new() { Id = 61, Name = "Denmark", TwoLetterIsoCode = "DK", ThreeLetterIsoCode = "DNK" },
        StateProvince = [
            new () {
                Id = 341,
                Name = "Hovedstaden",
                CountryId = 61
            },
            new () {
                Id = 342,
                Name = "Midtjylland",
                CountryId = 61
            },
            new () {
                Id = 343,
                Name = "Nordjylland",
                CountryId = 61
            },
            new () {
                Id = 344,
                Name = "Sjælland",
                CountryId = 61
            },
            new () {
                Id = 345,
                Name = "Syddanmark",
                CountryId = 61
            },
        ]
    },
    new() {
        Country = new() { Id = 62, Name = "Djibouti", TwoLetterIsoCode = "DJ", ThreeLetterIsoCode = "DJI" },
    },
    new() {
        Country = new() { Id = 63, Name = "Dominica", TwoLetterIsoCode = "DM", ThreeLetterIsoCode = "DMA" },
    },
    new() {
        Country = new() { Id = 64, Name = "Dominican Republic", TwoLetterIsoCode = "DO", ThreeLetterIsoCode = "DOM" },
    },
    new() {
        Country = new() { Id = 65, Name = "Ecuador", TwoLetterIsoCode = "EC", ThreeLetterIsoCode = "ECU" },
    },
    new() {
        Country = new() { Id = 66, Name = "Egypt", TwoLetterIsoCode = "EG", ThreeLetterIsoCode = "EGY" },
        StateProvince = [
            new () {
                Id = 377,
                Name = "Cairo",
                CountryId = 66
            },
            new () {
                Id = 378,
                Name = "Alexandria",
                CountryId = 66
            },
            new () {
                Id = 379,
                Name = "Ismailia",
                CountryId = 66
            },
            new () {
                Id = 380,
                Name = "Aswan",
                CountryId = 66
            },
            new () {
                Id = 381,
                Name = "Asyut",
                CountryId = 66
            },
            new () {
                Id = 382,
                Name = "Beheira",
                CountryId = 66
            },
            new () {
                Id = 383,
                Name = "Beni Suef",
                CountryId = 66
            },
            new () {
                Id = 384,
                Name = "Dakahlia",
                CountryId = 66
            },
            new () {
                Id = 385,
                Name = "Damietta",
                CountryId = 66
            },
            new () {
                Id = 386,
                Name = "Faiyum",
                CountryId = 66
            },
            new () {
                Id = 387,
                Name = "Gharbia",
                CountryId = 66
            },
            new () {
                Id = 388,
                Name = "Giza",
                CountryId = 66
            },
            new () {
                Id = 389,
                Name = "Kafr El Sheikh",
                CountryId = 66
            },
            new () {
                Id = 390,
                Name = "Luxor",
                CountryId = 66
            },
            new () {
                Id = 391,
                Name = "Matruh",
                CountryId = 66
            },
            new () {
                Id = 392,
                Name = "Minya",
                CountryId = 66
            },
            new () {
                Id = 393,
                Name = "Monufia",
                CountryId = 66
            },
            new () {
                Id = 394,
                Name = "New Valley",
                CountryId = 66
            },
            new () {
                Id = 395,
                Name = "North Sinai",
                CountryId = 66
            },
            new () {
                Id = 396,
                Name = "Port Said",
                CountryId = 66
            },
            new () {
                Id = 397,
                Name = "Qalyubia",
                CountryId = 66
            },
            new () {
                Id = 398,
                Name = "Qena",
                CountryId = 66
            },
            new () {
                Id = 399,
                Name = "Red Sea",
                CountryId = 66
            },
            new () {
                Id = 400,
                Name = "Sharqia",
                CountryId = 66
            },
            new () {
                Id = 401,
                Name = "Sohag",
                CountryId = 66
            },
            new () {
                Id = 402,
                Name = "South Sinai",
                CountryId = 66
            },
            new () {
                Id = 403,
                Name = "Suez",
                CountryId = 66
            },
        ]
    },
    new() {
        Country = new() { Id = 67, Name = "El Salvador", TwoLetterIsoCode = "SV", ThreeLetterIsoCode = "SLV" },
    },
    new() {
        Country = new() { Id = 68, Name = "Equatorial Guinea", TwoLetterIsoCode = "GQ", ThreeLetterIsoCode = "GNQ" },
    },
    new() {
        Country = new() { Id = 69, Name = "Eritrea", TwoLetterIsoCode = "ER", ThreeLetterIsoCode = "ERI" },
    },
    new() {
        Country = new() { Id = 70, Name = "Estonia", TwoLetterIsoCode = "EE", ThreeLetterIsoCode = "EST" },
        StateProvince = [
            new () {
                Id = 362,
                Name = "Harjumaa",
                CountryId = 70
            },
            new () {
                Id = 363,
                Name = "Hiiumaa",
                CountryId = 70
            },
            new () {
                Id = 364,
                Name = "Ida-Virumaa",
                CountryId = 70
            },
            new () {
                Id = 365,
                Name = "Jõgevamaa",
                CountryId = 70
            },
            new () {
                Id = 366,
                Name = "Järvamaa",
                CountryId = 70
            },
            new () {
                Id = 367,
                Name = "Läänemaa",
                CountryId = 70
            },
            new () {
                Id = 368,
                Name = "Lääne-Virumaa",
                CountryId = 70
            },
            new () {
                Id = 369,
                Name = "Põlvamaa",
                CountryId = 70
            },
            new () {
                Id = 370,
                Name = "Pärnumaa",
                CountryId = 70
            },
            new () {
                Id = 371,
                Name = "Raplamaa",
                CountryId = 70
            },
            new () {
                Id = 372,
                Name = "Saaremaa",
                CountryId = 70
            },
            new () {
                Id = 373,
                Name = "Tartumaa",
                CountryId = 70
            },
            new () {
                Id = 374,
                Name = "Valgamaa",
                CountryId = 70
            },
            new () {
                Id = 375,
                Name = "Viljandimaa",
                CountryId = 70
            },
            new () {
                Id = 376,
                Name = "Võrumaa",
                CountryId = 70
            },
        ]
    },
    new() {
        Country = new() { Id = 71, Name = "Eswatini", TwoLetterIsoCode = "SZ", ThreeLetterIsoCode = "SWZ" },
    },
    new() {
        Country = new() { Id = 72, Name = "Ethiopia", TwoLetterIsoCode = "ET", ThreeLetterIsoCode = "ETH" },
    },
    new() {
        Country = new() { Id = 73, Name = "Falkland Islands (Malvinas)", TwoLetterIsoCode = "FK", ThreeLetterIsoCode = "FLK" },
    },
    new() {
        Country = new() { Id = 74, Name = "Faroe Islands", TwoLetterIsoCode = "FO", ThreeLetterIsoCode = "FRO" },
    },
    new() {
        Country = new() { Id = 75, Name = "Fiji", TwoLetterIsoCode = "FJ", ThreeLetterIsoCode = "FJI" },
    },
    new() {
        Country = new() { Id = 76, Name = "Finland", TwoLetterIsoCode = "FI", ThreeLetterIsoCode = "FIN" },
        StateProvince = [
            new () {
                Id = 456,
                Name = "Ahvenanmaan maakunta/Landskapet Åland",
                CountryId = 76
            },
            new () {
                Id = 457,
                Name = "Etelä-Karjala/Södra Karelen",
                CountryId = 76
            },
            new () {
                Id = 458,
                Name = "Etelä-Pohjanmaa/Södra Österbotten",
                CountryId = 76
            },
            new () {
                Id = 459,
                Name = "Etelä-Savo/Södra Savolax",
                CountryId = 76
            },
            new () {
                Id = 460,
                Name = "Kainuu/Kajanaland",
                CountryId = 76
            },
            new () {
                Id = 461,
                Name = "Kanta-Häme/Egentliga Tavastland",
                CountryId = 76
            },
            new () {
                Id = 462,
                Name = "Keski-Pohjanmaa/Mellersta Österbotten",
                CountryId = 76
            },
            new () {
                Id = 463,
                Name = "Keski-Suomi/Mellersta Finland",
                CountryId = 76
            },
            new () {
                Id = 464,
                Name = "Kymenlaakso/Kymmenedalen",
                CountryId = 76
            },
            new () {
                Id = 465,
                Name = "Lappi/Lappland",
                CountryId = 76
            },
            new () {
                Id = 466,
                Name = "Pirkanmaa/Birkaland",
                CountryId = 76
            },
            new () {
                Id = 467,
                Name = "Pohjanmaa/Österbotten",
                CountryId = 76
            },
            new () {
                Id = 468,
                Name = "Pohjois-Karjala/Norra Karelen",
                CountryId = 76
            },
            new () {
                Id = 469,
                Name = "Pohjois-Pohjanmaa/Norra Österbotten",
                CountryId = 76
            },
            new () {
                Id = 470,
                Name = "Pohjois-Savo/Norra Savolax",
                CountryId = 76
            },
            new () {
                Id = 471,
                Name = "Päijät-Häme/Päijänne-Tavastland",
                CountryId = 76
            },
            new () {
                Id = 472,
                Name = "Satakunta/Satakunda",
                CountryId = 76
            },
            new () {
                Id = 473,
                Name = "Uusimaa/Nyland",
                CountryId = 76
            },
            new () {
                Id = 474,
                Name = "Varsinais-Suomi/Egentliga Finland",
                CountryId = 76
            },
        ]
    },
    new() {
        Country = new() { Id = 77, Name = "France", TwoLetterIsoCode = "FR", ThreeLetterIsoCode = "FRA" },
        StateProvince = [
            new () {
                Id = 475,
                Name = "Ain",
                CountryId = 77
            },
            new () {
                Id = 476,
                Name = "Aisne",
                CountryId = 77
            },
            new () {
                Id = 477,
                Name = "Allier",
                CountryId = 77
            },
            new () {
                Id = 478,
                Name = "Alpes de Hautes-Provence",
                CountryId = 77
            },
            new () {
                Id = 479,
                Name = "Alpes (Hautes)",
                CountryId = 77
            },
            new () {
                Id = 480,
                Name = "Alpes Maritimes",
                CountryId = 77
            },
            new () {
                Id = 481,
                Name = "Ardèche",
                CountryId = 77
            },
            new () {
                Id = 482,
                Name = "Ardennes",
                CountryId = 77
            },
            new () {
                Id = 483,
                Name = "Ariège",
                CountryId = 77
            },
            new () {
                Id = 484,
                Name = "Aube",
                CountryId = 77
            },
            new () {
                Id = 485,
                Name = "Aude",
                CountryId = 77
            },
            new () {
                Id = 486,
                Name = "Aveyron",
                CountryId = 77
            },
            new () {
                Id = 487,
                Name = "Bouches du Rhône",
                CountryId = 77
            },
            new () {
                Id = 488,
                Name = "Calvados",
                CountryId = 77
            },
            new () {
                Id = 489,
                Name = "Cantal",
                CountryId = 77
            },
            new () {
                Id = 490,
                Name = "Charente",
                CountryId = 77
            },
            new () {
                Id = 491,
                Name = "Charente Maritime",
                CountryId = 77
            },
            new () {
                Id = 492,
                Name = "Cher",
                CountryId = 77
            },
            new () {
                Id = 493,
                Name = "Corrèze",
                CountryId = 77
            },
            new () {
                Id = 494,
                Name = "Corse du sud",
                CountryId = 77
            },
            new () {
                Id = 495,
                Name = "Haute corse",
                CountryId = 77
            },
            new () {
                Id = 496,
                Name = "Côte-d'Or",
                CountryId = 77
            },
            new () {
                Id = 497,
                Name = "Côtes d'Armor",
                CountryId = 77
            },
            new () {
                Id = 498,
                Name = "Creuse",
                CountryId = 77
            },
            new () {
                Id = 499,
                Name = "Dordogne",
                CountryId = 77
            },
            new () {
                Id = 500,
                Name = "Doubs",
                CountryId = 77
            },
            new () {
                Id = 501,
                Name = "Drôme",
                CountryId = 77
            },
            new () {
                Id = 502,
                Name = "Eure",
                CountryId = 77
            },
            new () {
                Id = 503,
                Name = "Eure et Loir",
                CountryId = 77
            },
            new () {
                Id = 504,
                Name = "Finistère",
                CountryId = 77
            },
            new () {
                Id = 505,
                Name = "Gard",
                CountryId = 77
            },
            new () {
                Id = 506,
                Name = "Garonne (Haute)",
                CountryId = 77
            },
            new () {
                Id = 507,
                Name = "Gers",
                CountryId = 77
            },
            new () {
                Id = 508,
                Name = "Gironde",
                CountryId = 77
            },
            new () {
                Id = 509,
                Name = "Hérault",
                CountryId = 77
            },
            new () {
                Id = 510,
                Name = "Ille et Vilaine",
                CountryId = 77
            },
            new () {
                Id = 511,
                Name = "Indre",
                CountryId = 77
            },
            new () {
                Id = 512,
                Name = "Indre et Loire",
                CountryId = 77
            },
            new () {
                Id = 513,
                Name = "Isère",
                CountryId = 77
            },
            new () {
                Id = 514,
                Name = "Jura",
                CountryId = 77
            },
            new () {
                Id = 515,
                Name = "Landes",
                CountryId = 77
            },
            new () {
                Id = 516,
                Name = "Loir et Cher",
                CountryId = 77
            },
            new () {
                Id = 517,
                Name = "Loire",
                CountryId = 77
            },
            new () {
                Id = 518,
                Name = "Loire (Haute)",
                CountryId = 77
            },
            new () {
                Id = 519,
                Name = "Loire Atlantique",
                CountryId = 77
            },
            new () {
                Id = 520,
                Name = "Loiret",
                CountryId = 77
            },
            new () {
                Id = 521,
                Name = "Lot",
                CountryId = 77
            },
            new () {
                Id = 522,
                Name = "Lot et Garonne",
                CountryId = 77
            },
            new () {
                Id = 523,
                Name = "Lozère",
                CountryId = 77
            },
            new () {
                Id = 524,
                Name = "Maine et Loire",
                CountryId = 77
            },
            new () {
                Id = 525,
                Name = "Manche",
                CountryId = 77
            },
            new () {
                Id = 526,
                Name = "Marne",
                CountryId = 77
            },
            new () {
                Id = 527,
                Name = "Marne (Haute)",
                CountryId = 77
            },
            new () {
                Id = 528,
                Name = "Mayenne",
                CountryId = 77
            },
            new () {
                Id = 529,
                Name = "Meurthe et Moselle",
                CountryId = 77
            },
            new () {
                Id = 530,
                Name = "Meuse",
                CountryId = 77
            },
            new () {
                Id = 531,
                Name = "Morbihan",
                CountryId = 77
            },
            new () {
                Id = 532,
                Name = "Moselle",
                CountryId = 77
            },
            new () {
                Id = 533,
                Name = "Nièvre",
                CountryId = 77
            },
            new () {
                Id = 534,
                Name = "Nord",
                CountryId = 77
            },
            new () {
                Id = 535,
                Name = "Oise",
                CountryId = 77
            },
            new () {
                Id = 536,
                Name = "Orne",
                CountryId = 77
            },
            new () {
                Id = 537,
                Name = "Pas de Calais",
                CountryId = 77
            },
            new () {
                Id = 538,
                Name = "Puy de Dôme",
                CountryId = 77
            },
            new () {
                Id = 539,
                Name = "Pyrénées Atlantiques",
                CountryId = 77
            },
            new () {
                Id = 540,
                Name = "Pyrénées (Hautes)",
                CountryId = 77
            },
            new () {
                Id = 541,
                Name = "Pyrénées Orientales",
                CountryId = 77
            },
            new () {
                Id = 542,
                Name = "Rhin (Bas)",
                CountryId = 77
            },
            new () {
                Id = 543,
                Name = "Rhin (Haut)",
                CountryId = 77
            },
            new () {
                Id = 544,
                Name = "Rhône",
                CountryId = 77
            },
            new () {
                Id = 545,
                Name = "Saône (Haute)",
                CountryId = 77
            },
            new () {
                Id = 546,
                Name = "Saône et Loire",
                CountryId = 77
            },
            new () {
                Id = 547,
                Name = "Sarthe",
                CountryId = 77
            },
            new () {
                Id = 548,
                Name = "Savoie",
                CountryId = 77
            },
            new () {
                Id = 549,
                Name = "Savoie (Haute)",
                CountryId = 77
            },
            new () {
                Id = 550,
                Name = "Paris",
                CountryId = 77
            },
            new () {
                Id = 551,
                Name = "Seine Maritime",
                CountryId = 77
            },
            new () {
                Id = 552,
                Name = "Seine et Marne",
                CountryId = 77
            },
            new () {
                Id = 553,
                Name = "Yvelines",
                CountryId = 77
            },
            new () {
                Id = 554,
                Name = "Sèvres (Deux)",
                CountryId = 77
            },
            new () {
                Id = 555,
                Name = "Somme",
                CountryId = 77
            },
            new () {
                Id = 556,
                Name = "Tarn",
                CountryId = 77
            },
            new () {
                Id = 557,
                Name = "Tarn et Garonne",
                CountryId = 77
            },
            new () {
                Id = 558,
                Name = "Var",
                CountryId = 77
            },
            new () {
                Id = 559,
                Name = "Vaucluse",
                CountryId = 77
            },
            new () {
                Id = 560,
                Name = "Vendée",
                CountryId = 77
            },
            new () {
                Id = 561,
                Name = "Vienne",
                CountryId = 77
            },
            new () {
                Id = 562,
                Name = "Vienne (Haute)",
                CountryId = 77
            },
            new () {
                Id = 563,
                Name = "Vosges",
                CountryId = 77
            },
            new () {
                Id = 564,
                Name = "Yonne",
                CountryId = 77
            },
            new () {
                Id = 565,
                Name = "Belfort (Territoire de)",
                CountryId = 77
            },
            new () {
                Id = 566,
                Name = "Essonne",
                CountryId = 77
            },
            new () {
                Id = 567,
                Name = "Hauts de Seine",
                CountryId = 77
            },
            new () {
                Id = 568,
                Name = "Seine Saint Denis",
                CountryId = 77
            },
            new () {
                Id = 569,
                Name = "Val de Marne",
                CountryId = 77
            },
            new () {
                Id = 570,
                Name = "Val d'oise",
                CountryId = 77
            },
            new () {
                Id = 571,
                Name = "Guadeloupe",
                CountryId = 77
            },
            new () {
                Id = 572,
                Name = "Martinique",
                CountryId = 77
            },
            new () {
                Id = 573,
                Name = "Guyane",
                CountryId = 77
            },
            new () {
                Id = 574,
                Name = "Réunion",
                CountryId = 77
            },
            new () {
                Id = 575,
                Name = "Saint-Pierre-et-Miquelon",
                CountryId = 77
            },
            new () {
                Id = 576,
                Name = "Mayotte",
                CountryId = 77
            },
            new () {
                Id = 577,
                Name = "Terres Australes et Antarctiques",
                CountryId = 77
            },
            new () {
                Id = 578,
                Name = "Wallis et futuna",
                CountryId = 77
            },
            new () {
                Id = 579,
                Name = "Polynésie Française",
                CountryId = 77
            },
            new () {
                Id = 580,
                Name = "Nouvelle-Calédonie",
                CountryId = 77
            },
        ]
    },
    new() {
        Country = new() { Id = 78, Name = "French Guiana", TwoLetterIsoCode = "GF", ThreeLetterIsoCode = "GUF" },
    },
    new() {
        Country = new() { Id = 79, Name = "French Polynesia", TwoLetterIsoCode = "PF", ThreeLetterIsoCode = "PYF" },
    },
    new() {
        Country = new() { Id = 80, Name = "French Southern Territories", TwoLetterIsoCode = "TF", ThreeLetterIsoCode = "ATF" },
    },
    new() {
        Country = new() { Id = 81, Name = "Gabon", TwoLetterIsoCode = "GA", ThreeLetterIsoCode = "GAB" },
    },
    new() {
        Country = new() { Id = 82, Name = "Gambia", TwoLetterIsoCode = "GM", ThreeLetterIsoCode = "GMB" },
    },
    new() {
        Country = new() { Id = 83, Name = "Georgia", TwoLetterIsoCode = "GE", ThreeLetterIsoCode = "GEO" },
    },
    new() {
        Country = new() { Id = 84, Name = "Germany", TwoLetterIsoCode = "DE", ThreeLetterIsoCode = "DEU" },
        StateProvince = [
            new () {
                Id = 346,
                Name = "Baden-Württemberg",
                CountryId = 84
            },
            new () {
                Id = 347,
                Name = "Bayern",
                CountryId = 84
            },
            new () {
                Id = 348,
                Name = "Berlin",
                CountryId = 84
            },
            new () {
                Id = 349,
                Name = "Brandenburg",
                CountryId = 84
            },
            new () {
                Id = 350,
                Name = "Bremen",
                CountryId = 84
            },
            new () {
                Id = 351,
                Name = "Hamburg",
                CountryId = 84
            },
            new () {
                Id = 352,
                Name = "Hessen",
                CountryId = 84
            },
            new () {
                Id = 353,
                Name = "Mecklenburg-Vorpommern",
                CountryId = 84
            },
            new () {
                Id = 354,
                Name = "Niedersachsen",
                CountryId = 84
            },
            new () {
                Id = 355,
                Name = "Nordrhein-Westfalen",
                CountryId = 84
            },
            new () {
                Id = 356,
                Name = "Rheinland-Pfalz",
                CountryId = 84
            },
            new () {
                Id = 357,
                Name = "Saarland",
                CountryId = 84
            },
            new () {
                Id = 358,
                Name = "Sachsen",
                CountryId = 84
            },
            new () {
                Id = 359,
                Name = "Sachsen-Anhalt",
                CountryId = 84
            },
            new () {
                Id = 360,
                Name = "Schleswig-Holstein",
                CountryId = 84
            },
            new () {
                Id = 361,
                Name = "Thüringen",
                CountryId = 84
            },
        ]
    },
    new() {
        Country = new() { Id = 85, Name = "Ghana", TwoLetterIsoCode = "GH", ThreeLetterIsoCode = "GHA" },
    },
    new() {
        Country = new() { Id = 86, Name = "Gibraltar", TwoLetterIsoCode = "GI", ThreeLetterIsoCode = "GIB" },
    },
    new() {
        Country = new() { Id = 87, Name = "Greece", TwoLetterIsoCode = "GR", ThreeLetterIsoCode = "GRC" },
        StateProvince = [
            new () {
                Id = 682,
                Name = "ΑΙΤΩΛΟΑΚΑΡΝΑΝΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 683,
                Name = "ΑΡΓΟΛΙΔΑΣ",
                CountryId = 87
            },
            new () {
                Id = 684,
                Name = "ΑΡΚΑΔΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 685,
                Name = "ΑΡΤΑΣ",
                CountryId = 87
            },
            new () {
                Id = 686,
                Name = "ΑΤΤΙΚΗΣ",
                CountryId = 87
            },
            new () {
                Id = 687,
                Name = "ΑΧΑΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 688,
                Name = "ΒΟΙΩΤΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 689,
                Name = "ΓΡΕΒΕΝΩΝ",
                CountryId = 87
            },
            new () {
                Id = 690,
                Name = "ΔΡΑΜΑΣ",
                CountryId = 87
            },
            new () {
                Id = 691,
                Name = "ΔΩΔΕΚΑΝΗΣΟΥ",
                CountryId = 87
            },
            new () {
                Id = 692,
                Name = "ΕΒΡΟΥ",
                CountryId = 87
            },
            new () {
                Id = 693,
                Name = "ΕΥΒΟΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 694,
                Name = "ΕΥΡΥΤΑΝΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 695,
                Name = "ΖΑΚΥΝΘΟΥ",
                CountryId = 87
            },
            new () {
                Id = 696,
                Name = "ΗΛΕΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 697,
                Name = "ΗΜΑΘΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 698,
                Name = "ΗΡΑΚΛΕΙΟΥ",
                CountryId = 87
            },
            new () {
                Id = 699,
                Name = "ΘΕΣΠΡΩΤΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 700,
                Name = "ΘΕΣΣΑΛΟΝΙΚΗΣ",
                CountryId = 87
            },
            new () {
                Id = 701,
                Name = "ΙΩΑΝΝΙΝΩΝ",
                CountryId = 87
            },
            new () {
                Id = 702,
                Name = "ΚΑΒΑΛΑΣ",
                CountryId = 87
            },
            new () {
                Id = 703,
                Name = "ΚΑΡΔΙΤΣΑΣ",
                CountryId = 87
            },
            new () {
                Id = 704,
                Name = "ΚΑΣΤΟΡΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 705,
                Name = "ΚΕΡΚΥΡΑΣ",
                CountryId = 87
            },
            new () {
                Id = 706,
                Name = "ΚΕΦΑΛΛΗΝΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 707,
                Name = "ΚΙΛΚΙΣ",
                CountryId = 87
            },
            new () {
                Id = 708,
                Name = "ΚΟΖΑΝΗΣ",
                CountryId = 87
            },
            new () {
                Id = 709,
                Name = "ΚΟΡΙΝΘΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 710,
                Name = "ΚΥΚΛΑΔΩΝ",
                CountryId = 87
            },
            new () {
                Id = 711,
                Name = "ΛΑΚΩΝΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 712,
                Name = "ΛΑΡΙΣΑΣ",
                CountryId = 87
            },
            new () {
                Id = 713,
                Name = "ΛΑΣΙΘΙΟΥ",
                CountryId = 87
            },
            new () {
                Id = 714,
                Name = "ΛΕΣΒΟΥ",
                CountryId = 87
            },
            new () {
                Id = 715,
                Name = "ΛΕΥΚΑΔΑΣ",
                CountryId = 87
            },
            new () {
                Id = 716,
                Name = "ΜΑΓΝΗΣΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 717,
                Name = "ΜΕΣΣΗΝΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 718,
                Name = "ΞΑΝΘΗΣ",
                CountryId = 87
            },
            new () {
                Id = 719,
                Name = "ΠΕΛΛΗΣ",
                CountryId = 87
            },
            new () {
                Id = 720,
                Name = "ΠΙΕΡΙΑΣ",
                CountryId = 87
            },
            new () {
                Id = 721,
                Name = "ΠΡΕΒΕΖΑΣ",
                CountryId = 87
            },
            new () {
                Id = 722,
                Name = "ΡΕΘΥΜΝΗΣ",
                CountryId = 87
            },
            new () {
                Id = 723,
                Name = "ΡΟΔΟΠΗΣ",
                CountryId = 87
            },
            new () {
                Id = 724,
                Name = "ΣΑΜΟΥ",
                CountryId = 87
            },
            new () {
                Id = 725,
                Name = "ΣΕΡΡΩΝ",
                CountryId = 87
            },
            new () {
                Id = 726,
                Name = "ΤΡΙΚΑΛΩΝ",
                CountryId = 87
            },
            new () {
                Id = 727,
                Name = "ΦΘΙΩΤΙΔΑΣ",
                CountryId = 87
            },
            new () {
                Id = 728,
                Name = "ΦΛΩΡΙΝΑΣ",
                CountryId = 87
            },
            new () {
                Id = 729,
                Name = "ΦΩΚΙΔΑΣ",
                CountryId = 87
            },
            new () {
                Id = 730,
                Name = "ΧΑΛΚΙΔΙΚΗΣ",
                CountryId = 87
            },
            new () {
                Id = 731,
                Name = "ΧΑΝΙΩΝ",
                CountryId = 87
            },
            new () {
                Id = 732,
                Name = "ΧΙΟΥ",
                CountryId = 87
            },
        ]
    },
    new() {
        Country = new() { Id = 88, Name = "Greenland", TwoLetterIsoCode = "GL", ThreeLetterIsoCode = "GRL" },
    },
    new() {
        Country = new() { Id = 89, Name = "Grenada", TwoLetterIsoCode = "GD", ThreeLetterIsoCode = "GRD" },
    },
    new() {
        Country = new() { Id = 90, Name = "Guadeloupe", TwoLetterIsoCode = "GP", ThreeLetterIsoCode = "GLP" },
    },
    new() {
        Country = new() { Id = 91, Name = "Guam", TwoLetterIsoCode = "GU", ThreeLetterIsoCode = "GUM" },
    },
    new() {
        Country = new() { Id = 92, Name = "Guatemala", TwoLetterIsoCode = "GT", ThreeLetterIsoCode = "GTM" },
    },
    new() {
        Country = new() { Id = 93, Name = "Guernsey", TwoLetterIsoCode = "GG", ThreeLetterIsoCode = "GGY" },
    },
    new() {
        Country = new() { Id = 94, Name = "Guinea", TwoLetterIsoCode = "GN", ThreeLetterIsoCode = "GIN" },
    },
    new() {
        Country = new() { Id = 95, Name = "Guinea-Bissau", TwoLetterIsoCode = "GW", ThreeLetterIsoCode = "GNB" },
    },
    new() {
        Country = new() { Id = 96, Name = "Guyana", TwoLetterIsoCode = "GY", ThreeLetterIsoCode = "GUY" },
    },
    new() {
        Country = new() { Id = 97, Name = "Haiti", TwoLetterIsoCode = "HT", ThreeLetterIsoCode = "HTI" },
    },
    new() {
        Country = new() { Id = 98, Name = "Heard Island and McDonald Islands", TwoLetterIsoCode = "HM", ThreeLetterIsoCode = "HMD" },
    },
    new() {
        Country = new() { Id = 99, Name = "Holy See", TwoLetterIsoCode = "VA", ThreeLetterIsoCode = "VAT" },
    },
    new() {
        Country = new() { Id = 100, Name = "Honduras", TwoLetterIsoCode = "HN", ThreeLetterIsoCode = "HND" },
    },
    new() {
        Country = new() { Id = 101, Name = "Hong Kong", TwoLetterIsoCode = "HK", ThreeLetterIsoCode = "HKG" },
    },
    new() {
        Country = new() { Id = 102, Name = "Hungary", TwoLetterIsoCode = "HU", ThreeLetterIsoCode = "HUN" },
        StateProvince = [
            new () {
                Id = 754,
                Name = "Budapest",
                CountryId = 102
            },
            new () {
                Id = 755,
                Name = "Bács-Kiskun",
                CountryId = 102
            },
            new () {
                Id = 756,
                Name = "Baranya",
                CountryId = 102
            },
            new () {
                Id = 757,
                Name = "Békés",
                CountryId = 102
            },
            new () {
                Id = 758,
                Name = "Borsod-Abaúj-Zemplén",
                CountryId = 102
            },
            new () {
                Id = 759,
                Name = "Csongrád",
                CountryId = 102
            },
            new () {
                Id = 760,
                Name = "Fejér",
                CountryId = 102
            },
            new () {
                Id = 761,
                Name = "Győr-Moson-Sopron",
                CountryId = 102
            },
            new () {
                Id = 762,
                Name = "Hajdú-Bihar",
                CountryId = 102
            },
            new () {
                Id = 763,
                Name = "Heves",
                CountryId = 102
            },
            new () {
                Id = 764,
                Name = "Jász-Nagykun-Szolnok",
                CountryId = 102
            },
            new () {
                Id = 765,
                Name = "Komárom-Esztergom",
                CountryId = 102
            },
            new () {
                Id = 766,
                Name = "Nógrád",
                CountryId = 102
            },
            new () {
                Id = 767,
                Name = "Pest",
                CountryId = 102
            },
            new () {
                Id = 768,
                Name = "Somogy",
                CountryId = 102
            },
            new () {
                Id = 769,
                Name = "Szabolcs-Szatmár-Bereg",
                CountryId = 102
            },
            new () {
                Id = 770,
                Name = "Tolna",
                CountryId = 102
            },
            new () {
                Id = 771,
                Name = "Vas",
                CountryId = 102
            },
            new () {
                Id = 772,
                Name = "Veszprém",
                CountryId = 102
            },
            new () {
                Id = 773,
                Name = "Zala",
                CountryId = 102
            },
        ]
    },
    new() {
        Country = new() { Id = 103, Name = "Iceland", TwoLetterIsoCode = "IS", ThreeLetterIsoCode = "ISL" },
        StateProvince = [
            new () {
                Id = 901,
                Name = "Höfuðborgarsvæðið",
                CountryId = 103
            },
            new () {
                Id = 902,
                Name = "Suðurnes",
                CountryId = 103
            },
            new () {
                Id = 903,
                Name = "Vesturland",
                CountryId = 103
            },
            new () {
                Id = 904,
                Name = "Vestfirðir",
                CountryId = 103
            },
            new () {
                Id = 905,
                Name = "Norðurland vestra",
                CountryId = 103
            },
            new () {
                Id = 906,
                Name = "Norðurland eystra",
                CountryId = 103
            },
            new () {
                Id = 907,
                Name = "Austurland",
                CountryId = 103
            },
            new () {
                Id = 908,
                Name = "Suðurland",
                CountryId = 103
            },
        ]
    },
    new() {
        Country = new() { Id = 104, Name = "India", TwoLetterIsoCode = "IN", ThreeLetterIsoCode = "IND" },
        StateProvince = [
            new () {
                Id = 834,
                Name = "Andhra Pradesh",
                CountryId = 104
            },
            new () {
                Id = 835,
                Name = "Arunachal Pradesh",
                CountryId = 104
            },
            new () {
                Id = 836,
                Name = "Assam",
                CountryId = 104
            },
            new () {
                Id = 837,
                Name = "Bihar",
                CountryId = 104
            },
            new () {
                Id = 838,
                Name = "Chhattisgarh",
                CountryId = 104
            },
            new () {
                Id = 839,
                Name = "Goa",
                CountryId = 104
            },
            new () {
                Id = 840,
                Name = "Gujarat",
                CountryId = 104
            },
            new () {
                Id = 841,
                Name = "Haryana",
                CountryId = 104
            },
            new () {
                Id = 842,
                Name = "Himachal Pradesh",
                CountryId = 104
            },
            new () {
                Id = 843,
                Name = "Jammu and Kashmir",
                CountryId = 104
            },
            new () {
                Id = 844,
                Name = "Jharkhand",
                CountryId = 104
            },
            new () {
                Id = 845,
                Name = "Karnataka",
                CountryId = 104
            },
            new () {
                Id = 846,
                Name = "Kerala",
                CountryId = 104
            },
            new () {
                Id = 847,
                Name = "Madhya Pradesh",
                CountryId = 104
            },
            new () {
                Id = 848,
                Name = "Maharashtra",
                CountryId = 104
            },
            new () {
                Id = 849,
                Name = "Manipur",
                CountryId = 104
            },
            new () {
                Id = 850,
                Name = "Meghalaya",
                CountryId = 104
            },
            new () {
                Id = 851,
                Name = "Mizoram",
                CountryId = 104
            },
            new () {
                Id = 852,
                Name = "Nagaland",
                CountryId = 104
            },
            new () {
                Id = 853,
                Name = "Odisha",
                CountryId = 104
            },
            new () {
                Id = 854,
                Name = "Punjab",
                CountryId = 104
            },
            new () {
                Id = 855,
                Name = "Rajasthan",
                CountryId = 104
            },
            new () {
                Id = 856,
                Name = "Sikkim",
                CountryId = 104
            },
            new () {
                Id = 857,
                Name = "Tamil Nadu",
                CountryId = 104
            },
            new () {
                Id = 858,
                Name = "Telangana",
                CountryId = 104
            },
            new () {
                Id = 859,
                Name = "Tripura",
                CountryId = 104
            },
            new () {
                Id = 860,
                Name = "Uttarakhand",
                CountryId = 104
            },
            new () {
                Id = 861,
                Name = "Uttar Pradesh",
                CountryId = 104
            },
            new () {
                Id = 862,
                Name = "West Bengal",
                CountryId = 104
            },
            new () {
                Id = 863,
                Name = "Andaman and Nicobar Islands",
                CountryId = 104
            },
            new () {
                Id = 864,
                Name = "Chandigarh",
                CountryId = 104
            },
            new () {
                Id = 865,
                Name = "Dadra and Nagar Haveli",
                CountryId = 104
            },
            new () {
                Id = 866,
                Name = "Daman and Diu",
                CountryId = 104
            },
            new () {
                Id = 867,
                Name = "Delhi",
                CountryId = 104
            },
            new () {
                Id = 868,
                Name = "Lakshadweep",
                CountryId = 104
            },
            new () {
                Id = 869,
                Name = "Puducherry",
                CountryId = 104
            },
        ]
    },
    new() {
        Country = new() { Id = 105, Name = "Indonesia", TwoLetterIsoCode = "ID", ThreeLetterIsoCode = "IDN" },
        StateProvince = [
            new () {
                Id = 774,
                Name = "Aceh",
                CountryId = 105
            },
            new () {
                Id = 775,
                Name = "Bali",
                CountryId = 105
            },
            new () {
                Id = 776,
                Name = "Banten",
                CountryId = 105
            },
            new () {
                Id = 777,
                Name = "Bengkulu",
                CountryId = 105
            },
            new () {
                Id = 778,
                Name = "Gorontalo",
                CountryId = 105
            },
            new () {
                Id = 779,
                Name = "Jakarta",
                CountryId = 105
            },
            new () {
                Id = 780,
                Name = "Jambi",
                CountryId = 105
            },
            new () {
                Id = 781,
                Name = "Jawa Barat",
                CountryId = 105
            },
            new () {
                Id = 782,
                Name = "Jawa Tengah",
                CountryId = 105
            },
            new () {
                Id = 783,
                Name = "Jawa Timur",
                CountryId = 105
            },
            new () {
                Id = 784,
                Name = "Kalimantan Barat",
                CountryId = 105
            },
            new () {
                Id = 785,
                Name = "Kalimantan Selatan",
                CountryId = 105
            },
            new () {
                Id = 786,
                Name = "Kalimantan Tengah",
                CountryId = 105
            },
            new () {
                Id = 787,
                Name = "Kalimantan Timur",
                CountryId = 105
            },
            new () {
                Id = 788,
                Name = "Kalimantan Utara",
                CountryId = 105
            },
            new () {
                Id = 789,
                Name = "Kepulauan Bangka Belitung",
                CountryId = 105
            },
            new () {
                Id = 790,
                Name = "Kepulauan Riau",
                CountryId = 105
            },
            new () {
                Id = 791,
                Name = "Lampung",
                CountryId = 105
            },
            new () {
                Id = 792,
                Name = "Maluku",
                CountryId = 105
            },
            new () {
                Id = 793,
                Name = "Maluku Utara",
                CountryId = 105
            },
            new () {
                Id = 794,
                Name = "Nusa Tenggara Barat",
                CountryId = 105
            },
            new () {
                Id = 795,
                Name = "Nusa Tenggara Timur",
                CountryId = 105
            },
            new () {
                Id = 796,
                Name = "Papua",
                CountryId = 105
            },
            new () {
                Id = 797,
                Name = "Papua Barat",
                CountryId = 105
            },
            new () {
                Id = 798,
                Name = "Riau",
                CountryId = 105
            },
            new () {
                Id = 799,
                Name = "Sulawesi Barat",
                CountryId = 105
            },
            new () {
                Id = 800,
                Name = "Sulawesi Selatan",
                CountryId = 105
            },
            new () {
                Id = 801,
                Name = "Sulawesi Tengah",
                CountryId = 105
            },
            new () {
                Id = 802,
                Name = "Sulawesi Tenggara",
                CountryId = 105
            },
            new () {
                Id = 803,
                Name = "Sulawesi Utara",
                CountryId = 105
            },
            new () {
                Id = 804,
                Name = "Sumatera Barat",
                CountryId = 105
            },
            new () {
                Id = 805,
                Name = "Sumatera Selatan",
                CountryId = 105
            },
            new () {
                Id = 806,
                Name = "Sumatera Utara",
                CountryId = 105
            },
            new () {
                Id = 807,
                Name = "Yogyakarta",
                CountryId = 105
            },
        ]
    },
    new() {
        Country = new() { Id = 106, Name = "Iran (Islamic Republic of)", TwoLetterIsoCode = "IR", ThreeLetterIsoCode = "IRN" },
        StateProvince = [
            new () {
                Id = 870,
                Name = "آذربایجان شرقی",
                CountryId = 106
            },
            new () {
                Id = 871,
                Name = "آذربایجان غربی",
                CountryId = 106
            },
            new () {
                Id = 872,
                Name = "اردبیل",
                CountryId = 106
            },
            new () {
                Id = 873,
                Name = "اصفهان",
                CountryId = 106
            },
            new () {
                Id = 874,
                Name = "البرز",
                CountryId = 106
            },
            new () {
                Id = 875,
                Name = "ایلام",
                CountryId = 106
            },
            new () {
                Id = 876,
                Name = "بوشهر",
                CountryId = 106
            },
            new () {
                Id = 877,
                Name = "تهران",
                CountryId = 106
            },
            new () {
                Id = 878,
                Name = "چهارمحال و بختیاری",
                CountryId = 106
            },
            new () {
                Id = 879,
                Name = "خراسان جنوبی",
                CountryId = 106
            },
            new () {
                Id = 880,
                Name = "خراسان رضوی",
                CountryId = 106
            },
            new () {
                Id = 881,
                Name = "خراسان شمالی",
                CountryId = 106
            },
            new () {
                Id = 882,
                Name = "خوزستان",
                CountryId = 106
            },
            new () {
                Id = 883,
                Name = "زنجان",
                CountryId = 106
            },
            new () {
                Id = 884,
                Name = "سمنان",
                CountryId = 106
            },
            new () {
                Id = 885,
                Name = "سیستان و بلوچستان",
                CountryId = 106
            },
            new () {
                Id = 886,
                Name = "فارس",
                CountryId = 106
            },
            new () {
                Id = 887,
                Name = "قزوین",
                CountryId = 106
            },
            new () {
                Id = 888,
                Name = "قم",
                CountryId = 106
            },
            new () {
                Id = 889,
                Name = "کردستان",
                CountryId = 106
            },
            new () {
                Id = 890,
                Name = "کرمان",
                CountryId = 106
            },
            new () {
                Id = 891,
                Name = "کرمانشاه",
                CountryId = 106
            },
            new () {
                Id = 892,
                Name = "کهگیلویه و بویراحمد",
                CountryId = 106
            },
            new () {
                Id = 893,
                Name = "گلستان",
                CountryId = 106
            },
            new () {
                Id = 894,
                Name = "گیلان",
                CountryId = 106
            },
            new () {
                Id = 895,
                Name = "لرستان",
                CountryId = 106
            },
            new () {
                Id = 896,
                Name = "مازندران",
                CountryId = 106
            },
            new () {
                Id = 897,
                Name = "مرکزی",
                CountryId = 106
            },
            new () {
                Id = 898,
                Name = "هرمزگان",
                CountryId = 106
            },
            new () {
                Id = 899,
                Name = "همدان",
                CountryId = 106
            },
            new () {
                Id = 900,
                Name = "یزد",
                CountryId = 106
            },
        ]
    },
    new() {
        Country = new() { Id = 107, Name = "Iraq", TwoLetterIsoCode = "IQ", ThreeLetterIsoCode = "IRQ" },
    },
    new() {
        Country = new() { Id = 108, Name = "Ireland", TwoLetterIsoCode = "IE", ThreeLetterIsoCode = "IRL" },
        StateProvince = [
            new () {
                Id = 808,
                Name = "County Carlow",
                CountryId = 108
            },
            new () {
                Id = 809,
                Name = "County Cavan",
                CountryId = 108
            },
            new () {
                Id = 810,
                Name = "County Clare",
                CountryId = 108
            },
            new () {
                Id = 811,
                Name = "County Cork",
                CountryId = 108
            },
            new () {
                Id = 812,
                Name = "County Donegal",
                CountryId = 108
            },
            new () {
                Id = 813,
                Name = "County Dublin",
                CountryId = 108
            },
            new () {
                Id = 814,
                Name = "County Galway",
                CountryId = 108
            },
            new () {
                Id = 815,
                Name = "County Kerry",
                CountryId = 108
            },
            new () {
                Id = 816,
                Name = "County Kildare",
                CountryId = 108
            },
            new () {
                Id = 817,
                Name = "County Kilkenny",
                CountryId = 108
            },
            new () {
                Id = 818,
                Name = "County Laois",
                CountryId = 108
            },
            new () {
                Id = 819,
                Name = "County Leitrim",
                CountryId = 108
            },
            new () {
                Id = 820,
                Name = "County Limerick",
                CountryId = 108
            },
            new () {
                Id = 821,
                Name = "County Longford",
                CountryId = 108
            },
            new () {
                Id = 822,
                Name = "County Louth",
                CountryId = 108
            },
            new () {
                Id = 823,
                Name = "County Mayo",
                CountryId = 108
            },
            new () {
                Id = 824,
                Name = "County Meath",
                CountryId = 108
            },
            new () {
                Id = 825,
                Name = "County Monaghan",
                CountryId = 108
            },
            new () {
                Id = 826,
                Name = "County Offaly",
                CountryId = 108
            },
            new () {
                Id = 827,
                Name = "County Roscommon",
                CountryId = 108
            },
            new () {
                Id = 828,
                Name = "County Sligo",
                CountryId = 108
            },
            new () {
                Id = 829,
                Name = "County Tipperary",
                CountryId = 108
            },
            new () {
                Id = 830,
                Name = "County Waterford",
                CountryId = 108
            },
            new () {
                Id = 831,
                Name = "County Westmeath",
                CountryId = 108
            },
            new () {
                Id = 832,
                Name = "County Wexford",
                CountryId = 108
            },
            new () {
                Id = 833,
                Name = "County Wicklow",
                CountryId = 108
            },
        ]
    },
    new() {
        Country = new() { Id = 109, Name = "Isle of Man", TwoLetterIsoCode = "IM", ThreeLetterIsoCode = "IMN" },
    },
    new() {
        Country = new() { Id = 110, Name = "Israel", TwoLetterIsoCode = "IL", ThreeLetterIsoCode = "ISR" },
    },
    new() {
        Country = new() { Id = 111, Name = "Italy", TwoLetterIsoCode = "IT", ThreeLetterIsoCode = "ITA" },
        StateProvince = [
            new () {
                Id = 909,
                Name = "Agrigento",
                CountryId = 111
            },
            new () {
                Id = 910,
                Name = "Alessandria",
                CountryId = 111
            },
            new () {
                Id = 911,
                Name = "Ancona",
                CountryId = 111
            },
            new () {
                Id = 912,
                Name = "Aosta",
                CountryId = 111
            },
            new () {
                Id = 913,
                Name = "Arezzo",
                CountryId = 111
            },
            new () {
                Id = 914,
                Name = "Ascoli Piceno",
                CountryId = 111
            },
            new () {
                Id = 915,
                Name = "Asti",
                CountryId = 111
            },
            new () {
                Id = 916,
                Name = "Avellino",
                CountryId = 111
            },
            new () {
                Id = 917,
                Name = "Bari",
                CountryId = 111
            },
            new () {
                Id = 918,
                Name = "Barletta-Andria-Trani",
                CountryId = 111
            },
            new () {
                Id = 919,
                Name = "Belluno",
                CountryId = 111
            },
            new () {
                Id = 920,
                Name = "Benevento",
                CountryId = 111
            },
            new () {
                Id = 921,
                Name = "Bergamo",
                CountryId = 111
            },
            new () {
                Id = 922,
                Name = "Biella",
                CountryId = 111
            },
            new () {
                Id = 923,
                Name = "Bologna",
                CountryId = 111
            },
            new () {
                Id = 924,
                Name = "Bolzano",
                CountryId = 111
            },
            new () {
                Id = 925,
                Name = "Brescia",
                CountryId = 111
            },
            new () {
                Id = 926,
                Name = "Brindisi",
                CountryId = 111
            },
            new () {
                Id = 927,
                Name = "Cagliari",
                CountryId = 111
            },
            new () {
                Id = 928,
                Name = "Caltanissetta",
                CountryId = 111
            },
            new () {
                Id = 929,
                Name = "Campobasso",
                CountryId = 111
            },
            new () {
                Id = 930,
                Name = "Carbonia-Iglesias",
                CountryId = 111
            },
            new () {
                Id = 931,
                Name = "Caserta",
                CountryId = 111
            },
            new () {
                Id = 932,
                Name = "Catania",
                CountryId = 111
            },
            new () {
                Id = 933,
                Name = "Catanzaro",
                CountryId = 111
            },
            new () {
                Id = 934,
                Name = "Chieti",
                CountryId = 111
            },
            new () {
                Id = 935,
                Name = "Como",
                CountryId = 111
            },
            new () {
                Id = 936,
                Name = "Cosenza",
                CountryId = 111
            },
            new () {
                Id = 937,
                Name = "Cremona",
                CountryId = 111
            },
            new () {
                Id = 938,
                Name = "Crotone",
                CountryId = 111
            },
            new () {
                Id = 939,
                Name = "Cuneo",
                CountryId = 111
            },
            new () {
                Id = 940,
                Name = "Enna",
                CountryId = 111
            },
            new () {
                Id = 941,
                Name = "Fermo",
                CountryId = 111
            },
            new () {
                Id = 942,
                Name = "Ferrara",
                CountryId = 111
            },
            new () {
                Id = 943,
                Name = "Firenze",
                CountryId = 111
            },
            new () {
                Id = 944,
                Name = "Foggia",
                CountryId = 111
            },
            new () {
                Id = 945,
                Name = "Forlì-Cesena",
                CountryId = 111
            },
            new () {
                Id = 946,
                Name = "Frosinone",
                CountryId = 111
            },
            new () {
                Id = 947,
                Name = "Genova",
                CountryId = 111
            },
            new () {
                Id = 948,
                Name = "Gorizia",
                CountryId = 111
            },
            new () {
                Id = 949,
                Name = "Grosseto",
                CountryId = 111
            },
            new () {
                Id = 950,
                Name = "Imperia",
                CountryId = 111
            },
            new () {
                Id = 951,
                Name = "Isernia",
                CountryId = 111
            },
            new () {
                Id = 952,
                Name = "La Spezia",
                CountryId = 111
            },
            new () {
                Id = 953,
                Name = "L'Aquila",
                CountryId = 111
            },
            new () {
                Id = 954,
                Name = "Latina",
                CountryId = 111
            },
            new () {
                Id = 955,
                Name = "Lecce",
                CountryId = 111
            },
            new () {
                Id = 956,
                Name = "Lecco",
                CountryId = 111
            },
            new () {
                Id = 957,
                Name = "Livorno",
                CountryId = 111
            },
            new () {
                Id = 958,
                Name = "Lodi",
                CountryId = 111
            },
            new () {
                Id = 959,
                Name = "Lucca",
                CountryId = 111
            },
            new () {
                Id = 960,
                Name = "Macerata",
                CountryId = 111
            },
            new () {
                Id = 961,
                Name = "Mantova",
                CountryId = 111
            },
            new () {
                Id = 962,
                Name = "Massa-Carrara",
                CountryId = 111
            },
            new () {
                Id = 963,
                Name = "Matera",
                CountryId = 111
            },
            new () {
                Id = 964,
                Name = "Medio Campidano",
                CountryId = 111
            },
            new () {
                Id = 965,
                Name = "Messina",
                CountryId = 111
            },
            new () {
                Id = 966,
                Name = "Milano",
                CountryId = 111
            },
            new () {
                Id = 967,
                Name = "Modena",
                CountryId = 111
            },
            new () {
                Id = 968,
                Name = "Monza e della Brianza",
                CountryId = 111
            },
            new () {
                Id = 969,
                Name = "Napoli",
                CountryId = 111
            },
            new () {
                Id = 970,
                Name = "Novara",
                CountryId = 111
            },
            new () {
                Id = 971,
                Name = "Nuoro",
                CountryId = 111
            },
            new () {
                Id = 972,
                Name = "Ogliastra",
                CountryId = 111
            },
            new () {
                Id = 973,
                Name = "Olbia-Tempio",
                CountryId = 111
            },
            new () {
                Id = 974,
                Name = "Oristano",
                CountryId = 111
            },
            new () {
                Id = 975,
                Name = "Padova",
                CountryId = 111
            },
            new () {
                Id = 976,
                Name = "Palermo",
                CountryId = 111
            },
            new () {
                Id = 977,
                Name = "Parma",
                CountryId = 111
            },
            new () {
                Id = 978,
                Name = "Pavia",
                CountryId = 111
            },
            new () {
                Id = 979,
                Name = "Perugia",
                CountryId = 111
            },
            new () {
                Id = 980,
                Name = "Pesaro e Urbino",
                CountryId = 111
            },
            new () {
                Id = 981,
                Name = "Pescara",
                CountryId = 111
            },
            new () {
                Id = 982,
                Name = "Piacenza",
                CountryId = 111
            },
            new () {
                Id = 983,
                Name = "Pisa",
                CountryId = 111
            },
            new () {
                Id = 984,
                Name = "Pistoia",
                CountryId = 111
            },
            new () {
                Id = 985,
                Name = "Pordenone",
                CountryId = 111
            },
            new () {
                Id = 986,
                Name = "Potenza",
                CountryId = 111
            },
            new () {
                Id = 987,
                Name = "Prato",
                CountryId = 111
            },
            new () {
                Id = 988,
                Name = "Ragusa",
                CountryId = 111
            },
            new () {
                Id = 989,
                Name = "Ravenna",
                CountryId = 111
            },
            new () {
                Id = 990,
                Name = "Reggio Calabria",
                CountryId = 111
            },
            new () {
                Id = 991,
                Name = "Reggio Emilia",
                CountryId = 111
            },
            new () {
                Id = 992,
                Name = "Rieti",
                CountryId = 111
            },
            new () {
                Id = 993,
                Name = "Rimini",
                CountryId = 111
            },
            new () {
                Id = 994,
                Name = "Roma",
                CountryId = 111
            },
            new () {
                Id = 995,
                Name = "Rovigo",
                CountryId = 111
            },
            new () {
                Id = 996,
                Name = "Salerno",
                CountryId = 111
            },
            new () {
                Id = 997,
                Name = "Sassari",
                CountryId = 111
            },
            new () {
                Id = 998,
                Name = "Savona",
                CountryId = 111
            },
            new () {
                Id = 999,
                Name = "Siena",
                CountryId = 111
            },
            new () {
                Id = 1000,
                Name = "Siracusa",
                CountryId = 111
            },
            new () {
                Id = 1001,
                Name = "Sondrio",
                CountryId = 111
            },
            new () {
                Id = 1002,
                Name = "Taranto",
                CountryId = 111
            },
            new () {
                Id = 1003,
                Name = "Teramo",
                CountryId = 111
            },
            new () {
                Id = 1004,
                Name = "Terni",
                CountryId = 111
            },
            new () {
                Id = 1005,
                Name = "Torino",
                CountryId = 111
            },
            new () {
                Id = 1006,
                Name = "Trapani",
                CountryId = 111
            },
            new () {
                Id = 1007,
                Name = "Trento",
                CountryId = 111
            },
            new () {
                Id = 1008,
                Name = "Treviso",
                CountryId = 111
            },
            new () {
                Id = 1009,
                Name = "Trieste",
                CountryId = 111
            },
            new () {
                Id = 1010,
                Name = "Udine",
                CountryId = 111
            },
            new () {
                Id = 1011,
                Name = "Varese",
                CountryId = 111
            },
            new () {
                Id = 1012,
                Name = "Venezia",
                CountryId = 111
            },
            new () {
                Id = 1013,
                Name = "Verbano-Cusio-Ossola",
                CountryId = 111
            },
            new () {
                Id = 1014,
                Name = "Vercelli",
                CountryId = 111
            },
            new () {
                Id = 1015,
                Name = "Verona",
                CountryId = 111
            },
            new () {
                Id = 1016,
                Name = "Vibo Valentia",
                CountryId = 111
            },
            new () {
                Id = 1017,
                Name = "Vicenza",
                CountryId = 111
            },
            new () {
                Id = 1018,
                Name = "Viterbo",
                CountryId = 111
            },
        ]
    },
    new() {
        Country = new() { Id = 112, Name = "Jamaica", TwoLetterIsoCode = "JM", ThreeLetterIsoCode = "JAM" },
    },
    new() {
        Country = new() { Id = 113, Name = "Japan", TwoLetterIsoCode = "JP", ThreeLetterIsoCode = "JPN" },
    },
    new() {
        Country = new() { Id = 114, Name = "Jersey", TwoLetterIsoCode = "JE", ThreeLetterIsoCode = "JEY" },
    },
    new() {
        Country = new() { Id = 115, Name = "Jordan", TwoLetterIsoCode = "JO", ThreeLetterIsoCode = "JOR" },
    },
    new() {
        Country = new() { Id = 116, Name = "Kazakhstan", TwoLetterIsoCode = "KZ", ThreeLetterIsoCode = "KAZ" },
    },
    new() {
        Country = new() { Id = 117, Name = "Kenya", TwoLetterIsoCode = "KE", ThreeLetterIsoCode = "KEN" },
    },
    new() {
        Country = new() { Id = 118, Name = "Kiribati", TwoLetterIsoCode = "KI", ThreeLetterIsoCode = "KIR" },
    },
    new() {
        Country = new() { Id = 119, Name = "Korea (Democratic People's Republic of)", TwoLetterIsoCode = "KP", ThreeLetterIsoCode = "PRK" },
    },
    new() {
        Country = new() { Id = 120, Name = "Korea (Republic of)", TwoLetterIsoCode = "KR", ThreeLetterIsoCode = "KOR" },
    },
    new() {
        Country = new() { Id = 121, Name = "Kuwait", TwoLetterIsoCode = "KW", ThreeLetterIsoCode = "KWT" },
        StateProvince = [
            new () {
                Id = 1019,
                Name = "Al Asimah",
                CountryId = 121
            },
            new () {
                Id = 1020,
                Name = "Hawalli",
                CountryId = 121
            },
            new () {
                Id = 1021,
                Name = "Al Farwaniya",
                CountryId = 121
            },
            new () {
                Id = 1022,
                Name = "Mubarak Al Kabeer",
                CountryId = 121
            },
            new () {
                Id = 1023,
                Name = "Al Ahmadi",
                CountryId = 121
            },
            new () {
                Id = 1024,
                Name = "Al Jahraa",
                CountryId = 121
            },
        ]
    },
    new() {
        Country = new() { Id = 122, Name = "Kyrgyzstan", TwoLetterIsoCode = "KG", ThreeLetterIsoCode = "KGZ" },
    },
    new() {
        Country = new() { Id = 123, Name = "Lao People's Democratic Republic", TwoLetterIsoCode = "LA", ThreeLetterIsoCode = "LAO" },
    },
    new() {
        Country = new() { Id = 124, Name = "Latvia", TwoLetterIsoCode = "LV", ThreeLetterIsoCode = "LVA" },
    },
    new() {
        Country = new() { Id = 125, Name = "Lebanon", TwoLetterIsoCode = "LB", ThreeLetterIsoCode = "LBN" },
    },
    new() {
        Country = new() { Id = 126, Name = "Lesotho", TwoLetterIsoCode = "LS", ThreeLetterIsoCode = "LSO" },
    },
    new() {
        Country = new() { Id = 127, Name = "Liberia", TwoLetterIsoCode = "LR", ThreeLetterIsoCode = "LBR" },
    },
    new() {
        Country = new() { Id = 128, Name = "Libya", TwoLetterIsoCode = "LY", ThreeLetterIsoCode = "LBY" },
    },
    new() {
        Country = new() { Id = 129, Name = "Liechtenstein", TwoLetterIsoCode = "LI", ThreeLetterIsoCode = "LIE" },
    },
    new() {
        Country = new() { Id = 130, Name = "Lithuania", TwoLetterIsoCode = "LT", ThreeLetterIsoCode = "LTU" },
        StateProvince = [
            new () {
                Id = 1025,
                Name = "Alytaus apskritis",
                CountryId = 130
            },
            new () {
                Id = 1026,
                Name = "Kauno apskritis",
                CountryId = 130
            },
            new () {
                Id = 1027,
                Name = "Klaipėdos apskritis",
                CountryId = 130
            },
            new () {
                Id = 1028,
                Name = "Marijampolės apskritis",
                CountryId = 130
            },
            new () {
                Id = 1029,
                Name = "Panevėžio apskritis",
                CountryId = 130
            },
            new () {
                Id = 1030,
                Name = "Šiaulių apskritis",
                CountryId = 130
            },
            new () {
                Id = 1031,
                Name = "Tauragės apskritis",
                CountryId = 130
            },
            new () {
                Id = 1032,
                Name = "Telšių apskritis",
                CountryId = 130
            },
            new () {
                Id = 1033,
                Name = "Utenos apskritis",
                CountryId = 130
            },
            new () {
                Id = 1034,
                Name = "Vilniaus apskritis",
                CountryId = 130
            },
        ]
    },
    new() {
        Country = new() { Id = 131, Name = "Luxembourg", TwoLetterIsoCode = "LU", ThreeLetterIsoCode = "LUX" },
        StateProvince = [
            new () {
                Id = 1035,
                Name = "Capellen",
                CountryId = 131
            },
            new () {
                Id = 1036,
                Name = "Clerveaux",
                CountryId = 131
            },
            new () {
                Id = 1037,
                Name = "Diekirch",
                CountryId = 131
            },
            new () {
                Id = 1038,
                Name = "Echternach",
                CountryId = 131
            },
            new () {
                Id = 1039,
                Name = "Esch-Sur-Azette",
                CountryId = 131
            },
            new () {
                Id = 1040,
                Name = "Greven-Macher",
                CountryId = 131
            },
            new () {
                Id = 1041,
                Name = "Luxembourg Campagne",
                CountryId = 131
            },
            new () {
                Id = 1042,
                Name = "Mersch",
                CountryId = 131
            },
            new () {
                Id = 1043,
                Name = "Redange",
                CountryId = 131
            },
            new () {
                Id = 1044,
                Name = "Remich",
                CountryId = 131
            },
            new () {
                Id = 1045,
                Name = "Vianden",
                CountryId = 131
            },
            new () {
                Id = 1046,
                Name = "Wiltz",
                CountryId = 131
            },
        ]
    },
    new() {
        Country = new() { Id = 132, Name = "Macao", TwoLetterIsoCode = "MO", ThreeLetterIsoCode = "MAC" },
    },
    new() {
        Country = new() { Id = 133, Name = "North Macedonia", TwoLetterIsoCode = "MK", ThreeLetterIsoCode = "MKD" },
    },
    new() {
        Country = new() { Id = 134, Name = "Madagascar", TwoLetterIsoCode = "MG", ThreeLetterIsoCode = "MDG" },
    },
    new() {
        Country = new() { Id = 135, Name = "Malawi", TwoLetterIsoCode = "MW", ThreeLetterIsoCode = "MWI" },
    },
    new() {
        Country = new() { Id = 136, Name = "Malaysia", TwoLetterIsoCode = "MY", ThreeLetterIsoCode = "MYS" },
        StateProvince = [
            new () {
                Id = 1133,
                Name = "Johor",
                CountryId = 136
            },
            new () {
                Id = 1134,
                Name = "Kedah",
                CountryId = 136
            },
            new () {
                Id = 1135,
                Name = "Kelantan",
                CountryId = 136
            },
            new () {
                Id = 1136,
                Name = "Kuala Lumpur",
                CountryId = 136
            },
            new () {
                Id = 1137,
                Name = "Labuan",
                CountryId = 136
            },
            new () {
                Id = 1138,
                Name = "Melaka",
                CountryId = 136
            },
            new () {
                Id = 1139,
                Name = "Negeri Sembilan",
                CountryId = 136
            },
            new () {
                Id = 1140,
                Name = "Pahang",
                CountryId = 136
            },
            new () {
                Id = 1141,
                Name = "Perak",
                CountryId = 136
            },
            new () {
                Id = 1142,
                Name = "Perlis",
                CountryId = 136
            },
            new () {
                Id = 1143,
                Name = "Pulau Pinang",
                CountryId = 136
            },
            new () {
                Id = 1144,
                Name = "Putrajaya",
                CountryId = 136
            },
            new () {
                Id = 1145,
                Name = "Sabah",
                CountryId = 136
            },
            new () {
                Id = 1146,
                Name = "Sarawak",
                CountryId = 136
            },
            new () {
                Id = 1147,
                Name = "Selangor",
                CountryId = 136
            },
            new () {
                Id = 1148,
                Name = "Terengganu",
                CountryId = 136
            },
        ]
    },
    new() {
        Country = new() { Id = 137, Name = "Maldives", TwoLetterIsoCode = "MV", ThreeLetterIsoCode = "MDV" },
    },
    new() {
        Country = new() { Id = 138, Name = "Mali", TwoLetterIsoCode = "ML", ThreeLetterIsoCode = "MLI" },
    },
    new() {
        Country = new() { Id = 139, Name = "Malta", TwoLetterIsoCode = "MT", ThreeLetterIsoCode = "MLT" },
    },
    new() {
        Country = new() { Id = 140, Name = "Marshall Islands", TwoLetterIsoCode = "MH", ThreeLetterIsoCode = "MHL" },
    },
    new() {
        Country = new() { Id = 141, Name = "Martinique", TwoLetterIsoCode = "MQ", ThreeLetterIsoCode = "MTQ" },
    },
    new() {
        Country = new() { Id = 142, Name = "Mauritania", TwoLetterIsoCode = "MR", ThreeLetterIsoCode = "MRT" },
    },
    new() {
        Country = new() { Id = 143, Name = "Mauritius", TwoLetterIsoCode = "MU", ThreeLetterIsoCode = "MUS" },
    },
    new() {
        Country = new() { Id = 144, Name = "Mayotte", TwoLetterIsoCode = "YT", ThreeLetterIsoCode = "MYT" },
    },
    new() {
        Country = new() { Id = 145, Name = "Mexico", TwoLetterIsoCode = "MX", ThreeLetterIsoCode = "MEX" },
        StateProvince = [
            new () {
                Id = 1101,
                Name = "Aguascalientes",
                CountryId = 145
            },
            new () {
                Id = 1102,
                Name = "Baja California",
                CountryId = 145
            },
            new () {
                Id = 1103,
                Name = "Baja California Sur",
                CountryId = 145
            },
            new () {
                Id = 1104,
                Name = "Campeche",
                CountryId = 145
            },
            new () {
                Id = 1105,
                Name = "Chiapas",
                CountryId = 145
            },
            new () {
                Id = 1106,
                Name = "Chihuahua",
                CountryId = 145
            },
            new () {
                Id = 1107,
                Name = "Coahuila",
                CountryId = 145
            },
            new () {
                Id = 1108,
                Name = "Colima",
                CountryId = 145
            },
            new () {
                Id = 1109,
                Name = "Distrito Federal",
                CountryId = 145
            },
            new () {
                Id = 1110,
                Name = "Durango",
                CountryId = 145
            },
            new () {
                Id = 1111,
                Name = "Estado de México",
                CountryId = 145
            },
            new () {
                Id = 1112,
                Name = "Guanajuato",
                CountryId = 145
            },
            new () {
                Id = 1113,
                Name = "Guerrero",
                CountryId = 145
            },
            new () {
                Id = 1114,
                Name = "Hidalgo",
                CountryId = 145
            },
            new () {
                Id = 1115,
                Name = "Jalisco",
                CountryId = 145
            },
            new () {
                Id = 1116,
                Name = "Michoacán",
                CountryId = 145
            },
            new () {
                Id = 1117,
                Name = "Morelos",
                CountryId = 145
            },
            new () {
                Id = 1118,
                Name = "Nayarit",
                CountryId = 145
            },
            new () {
                Id = 1119,
                Name = "Nuevo León",
                CountryId = 145
            },
            new () {
                Id = 1120,
                Name = "Oaxaca",
                CountryId = 145
            },
            new () {
                Id = 1121,
                Name = "Puebla",
                CountryId = 145
            },
            new () {
                Id = 1122,
                Name = "Querétaro",
                CountryId = 145
            },
            new () {
                Id = 1123,
                Name = "Quintana Roo",
                CountryId = 145
            },
            new () {
                Id = 1124,
                Name = "San Luis Potosí",
                CountryId = 145
            },
            new () {
                Id = 1125,
                Name = "Sinaloa",
                CountryId = 145
            },
            new () {
                Id = 1126,
                Name = "Sonora",
                CountryId = 145
            },
            new () {
                Id = 1127,
                Name = "Tabasco",
                CountryId = 145
            },
            new () {
                Id = 1128,
                Name = "Tamaulipas",
                CountryId = 145
            },
            new () {
                Id = 1129,
                Name = "Tlaxcala",
                CountryId = 145
            },
            new () {
                Id = 1130,
                Name = "Veracruz",
                CountryId = 145
            },
            new () {
                Id = 1131,
                Name = "Yucatán",
                CountryId = 145
            },
            new () {
                Id = 1132,
                Name = "Zacatecas",
                CountryId = 145
            },
        ]
    },
    new() {
        Country = new() { Id = 146, Name = "Micronesia (Federated States of)", TwoLetterIsoCode = "FM", ThreeLetterIsoCode = "FSM" },
    },
    new() {
        Country = new() { Id = 147, Name = "Moldova (Republic of)", TwoLetterIsoCode = "MD", ThreeLetterIsoCode = "MDA" },
    },
    new() {
        Country = new() { Id = 148, Name = "Monaco", TwoLetterIsoCode = "MC", ThreeLetterIsoCode = "MCO" },
    },
    new() {
        Country = new() { Id = 149, Name = "Mongolia", TwoLetterIsoCode = "MN", ThreeLetterIsoCode = "MNG" },
        StateProvince = [
            new () {
                Id = 1071,
                Name = "Улаанбаатар хот - Багануур дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1072,
                Name = "Улаанбаатар хот - Багахангай дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1073,
                Name = "Улаанбаатар хот - Баянгол дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1074,
                Name = "Улаанбаатар хот - Баянзүрх дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1075,
                Name = "Улаанбаатар хот - Налайх дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1076,
                Name = "Улаанбаатар хот - Сонгино хайрхан дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1077,
                Name = "Улаанбаатар хот - Сүхбаатар дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1078,
                Name = "Улаанбаатар хот - Хан-Уул дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1079,
                Name = "Улаанбаатар хот - Чингэлтэй дүүрэг",
                CountryId = 149
            },
            new () {
                Id = 1080,
                Name = "Архангай аймаг",
                CountryId = 149
            },
            new () {
                Id = 1081,
                Name = "Баян-Өлгий аймаг",
                CountryId = 149
            },
            new () {
                Id = 1082,
                Name = "Баянхонгор аймаг",
                CountryId = 149
            },
            new () {
                Id = 1083,
                Name = "Булган аймаг",
                CountryId = 149
            },
            new () {
                Id = 1084,
                Name = "Өвөрхангай аймаг",
                CountryId = 149
            },
            new () {
                Id = 1085,
                Name = "Говь-Алтай аймаг",
                CountryId = 149
            },
            new () {
                Id = 1086,
                Name = "Говьсүмбэр аймаг",
                CountryId = 149
            },
            new () {
                Id = 1087,
                Name = "Дархан-Уул аймаг",
                CountryId = 149
            },
            new () {
                Id = 1088,
                Name = "Дорноговь аймаг",
                CountryId = 149
            },
            new () {
                Id = 1089,
                Name = "Дорнод аймаг",
                CountryId = 149
            },
            new () {
                Id = 1090,
                Name = "Дундговь аймаг",
                CountryId = 149
            },
            new () {
                Id = 1091,
                Name = "Завхан аймаг",
                CountryId = 149
            },
            new () {
                Id = 1092,
                Name = "Өмнөговь аймаг",
                CountryId = 149
            },
            new () {
                Id = 1093,
                Name = "Орхон аймаг",
                CountryId = 149
            },
            new () {
                Id = 1094,
                Name = "Сүхбаатар аймаг",
                CountryId = 149
            },
            new () {
                Id = 1095,
                Name = "Сэлэнгэ аймаг",
                CountryId = 149
            },
            new () {
                Id = 1096,
                Name = "Төв аймаг",
                CountryId = 149
            },
            new () {
                Id = 1097,
                Name = "Увс аймаг",
                CountryId = 149
            },
            new () {
                Id = 1098,
                Name = "Хөвсгөл аймаг",
                CountryId = 149
            },
            new () {
                Id = 1099,
                Name = "Ховд аймаг",
                CountryId = 149
            },
            new () {
                Id = 1100,
                Name = "Хэнтий аймаг",
                CountryId = 149
            },
        ]
    },
    new() {
        Country = new() { Id = 150, Name = "Montenegro", TwoLetterIsoCode = "ME", ThreeLetterIsoCode = "MNE" },
    },
    new() {
        Country = new() { Id = 151, Name = "Montserrat", TwoLetterIsoCode = "MS", ThreeLetterIsoCode = "MSR" },
    },
    new() {
        Country = new() { Id = 152, Name = "Morocco", TwoLetterIsoCode = "MA", ThreeLetterIsoCode = "MAR" },
        StateProvince = [
            new () {
                Id = 1047,
                Name = "Agadir",
                CountryId = 152
            },
            new () {
                Id = 1048,
                Name = "Beni mellal",
                CountryId = 152
            },
            new () {
                Id = 1049,
                Name = "Berkane",
                CountryId = 152
            },
            new () {
                Id = 1050,
                Name = "Casablanca",
                CountryId = 152
            },
            new () {
                Id = 1051,
                Name = "El jadida",
                CountryId = 152
            },
            new () {
                Id = 1052,
                Name = "Fes",
                CountryId = 152
            },
            new () {
                Id = 1053,
                Name = "Inezgane",
                CountryId = 152
            },
            new () {
                Id = 1054,
                Name = "Kenitra",
                CountryId = 152
            },
            new () {
                Id = 1055,
                Name = "Khemisset",
                CountryId = 152
            },
            new () {
                Id = 1056,
                Name = "Khenifra",
                CountryId = 152
            },
            new () {
                Id = 1057,
                Name = "Khouribga",
                CountryId = 152
            },
            new () {
                Id = 1058,
                Name = "Laayoune",
                CountryId = 152
            },
            new () {
                Id = 1059,
                Name = "Marrakech",
                CountryId = 152
            },
            new () {
                Id = 1060,
                Name = "Meknes",
                CountryId = 152
            },
            new () {
                Id = 1061,
                Name = "Mohammedia",
                CountryId = 152
            },
            new () {
                Id = 1062,
                Name = "Nador",
                CountryId = 152
            },
            new () {
                Id = 1063,
                Name = "Oujda",
                CountryId = 152
            },
            new () {
                Id = 1064,
                Name = "Rabat",
                CountryId = 152
            },
            new () {
                Id = 1065,
                Name = "Safi",
                CountryId = 152
            },
            new () {
                Id = 1066,
                Name = "Sale",
                CountryId = 152
            },
            new () {
                Id = 1067,
                Name = "Tanger",
                CountryId = 152
            },
            new () {
                Id = 1068,
                Name = "Taza",
                CountryId = 152
            },
            new () {
                Id = 1069,
                Name = "Temara",
                CountryId = 152
            },
            new () {
                Id = 1070,
                Name = "Tetouan",
                CountryId = 152
            },
        ]
    },
    new() {
        Country = new() { Id = 153, Name = "Mozambique", TwoLetterIsoCode = "MZ", ThreeLetterIsoCode = "MOZ" },
    },
    new() {
        Country = new() { Id = 154, Name = "Myanmar", TwoLetterIsoCode = "MM", ThreeLetterIsoCode = "MMR" },
    },
    new() {
        Country = new() { Id = 155, Name = "Namibia", TwoLetterIsoCode = "NA", ThreeLetterIsoCode = "NAM" },
    },
    new() {
        Country = new() { Id = 156, Name = "Nauru", TwoLetterIsoCode = "NR", ThreeLetterIsoCode = "NRU" },
    },
    new() {
        Country = new() { Id = 157, Name = "Nepal", TwoLetterIsoCode = "NP", ThreeLetterIsoCode = "NPL" },
        StateProvince = [
            new () {
                Id = 1219,
                Name = "Province No. 1",
                CountryId = 157
            },
            new () {
                Id = 1220,
                Name = "Province No. 2",
                CountryId = 157
            },
            new () {
                Id = 1221,
                Name = "Province No. 3",
                CountryId = 157
            },
            new () {
                Id = 1222,
                Name = "Gandaki Pradesh",
                CountryId = 157
            },
            new () {
                Id = 1223,
                Name = "Province No. 5",
                CountryId = 157
            },
            new () {
                Id = 1224,
                Name = "Karnali Pradesh",
                CountryId = 157
            },
            new () {
                Id = 1225,
                Name = "Sudurpashchim Pradesh",
                CountryId = 157
            },
        ]
    },
    new() {
        Country = new() { Id = 158, Name = "Netherlands", TwoLetterIsoCode = "NL", ThreeLetterIsoCode = "NLD" },
        StateProvince = [
            new () {
                Id = 1186,
                Name = "Drenthe",
                CountryId = 158
            },
            new () {
                Id = 1187,
                Name = "Flevoland",
                CountryId = 158
            },
            new () {
                Id = 1188,
                Name = "Friesland",
                CountryId = 158
            },
            new () {
                Id = 1189,
                Name = "Gelderland",
                CountryId = 158
            },
            new () {
                Id = 1190,
                Name = "Groningen",
                CountryId = 158
            },
            new () {
                Id = 1191,
                Name = "Limburg",
                CountryId = 158
            },
            new () {
                Id = 1192,
                Name = "Noord-Brabant",
                CountryId = 158
            },
            new () {
                Id = 1193,
                Name = "Noord-Holland",
                CountryId = 158
            },
            new () {
                Id = 1194,
                Name = "Overijssel",
                CountryId = 158
            },
            new () {
                Id = 1195,
                Name = "Utrecht",
                CountryId = 158
            },
            new () {
                Id = 1196,
                Name = "Zeeland",
                CountryId = 158
            },
            new () {
                Id = 1197,
                Name = "Zuid-Holland",
                CountryId = 158
            },
        ]
    },
    new() {
        Country = new() { Id = 159, Name = "New Caledonia", TwoLetterIsoCode = "NC", ThreeLetterIsoCode = "NCL" },
    },
    new() {
        Country = new() { Id = 160, Name = "New Zealand", TwoLetterIsoCode = "NZ", ThreeLetterIsoCode = "NZL" },
        StateProvince = [
            new () {
                Id = 1226,
                Name = "Northland",
                CountryId = 160
            },
            new () {
                Id = 1227,
                Name = "Auckland",
                CountryId = 160
            },
            new () {
                Id = 1228,
                Name = "Waikato",
                CountryId = 160
            },
            new () {
                Id = 1229,
                Name = "Waitomo",
                CountryId = 160
            },
            new () {
                Id = 1230,
                Name = "Bay of Plenty",
                CountryId = 160
            },
            new () {
                Id = 1231,
                Name = "Taupo",
                CountryId = 160
            },
            new () {
                Id = 1232,
                Name = "King Country",
                CountryId = 160
            },
            new () {
                Id = 1233,
                Name = "Taranaki",
                CountryId = 160
            },
            new () {
                Id = 1234,
                Name = "Wanganui",
                CountryId = 160
            },
            new () {
                Id = 1235,
                Name = "Manawatu",
                CountryId = 160
            },
            new () {
                Id = 1236,
                Name = "Horowhenua",
                CountryId = 160
            },
            new () {
                Id = 1237,
                Name = "Kapiti",
                CountryId = 160
            },
            new () {
                Id = 1238,
                Name = "Gisborne",
                CountryId = 160
            },
            new () {
                Id = 1239,
                Name = "Hawkes Bay",
                CountryId = 160
            },
            new () {
                Id = 1240,
                Name = "Wairarapa",
                CountryId = 160
            },
            new () {
                Id = 1241,
                Name = "Wellington",
                CountryId = 160
            },
            new () {
                Id = 1242,
                Name = "Nelson",
                CountryId = 160
            },
            new () {
                Id = 1243,
                Name = "Marlborough",
                CountryId = 160
            },
            new () {
                Id = 1244,
                Name = "Buller",
                CountryId = 160
            },
            new () {
                Id = 1245,
                Name = "West Coast",
                CountryId = 160
            },
            new () {
                Id = 1246,
                Name = "Canterbury",
                CountryId = 160
            },
            new () {
                Id = 1247,
                Name = "Otago",
                CountryId = 160
            },
            new () {
                Id = 1248,
                Name = "Southland",
                CountryId = 160
            },
        ]
    },
    new() {
        Country = new() { Id = 161, Name = "Nicaragua", TwoLetterIsoCode = "NI", ThreeLetterIsoCode = "NIC" },
    },
    new() {
        Country = new() { Id = 162, Name = "Niger", TwoLetterIsoCode = "NE", ThreeLetterIsoCode = "NER" },
    },
    new() {
        Country = new() { Id = 163, Name = "Nigeria", TwoLetterIsoCode = "NG", ThreeLetterIsoCode = "NGA" },
        StateProvince = [
            new () {
                Id = 1149,
                Name = "Abia",
                CountryId = 163
            },
            new () {
                Id = 1150,
                Name = "Adamawa",
                CountryId = 163
            },
            new () {
                Id = 1151,
                Name = "Akwa Ibom",
                CountryId = 163
            },
            new () {
                Id = 1152,
                Name = "Anambra",
                CountryId = 163
            },
            new () {
                Id = 1153,
                Name = "Bauchi",
                CountryId = 163
            },
            new () {
                Id = 1154,
                Name = "Bayelsa",
                CountryId = 163
            },
            new () {
                Id = 1155,
                Name = "Benue",
                CountryId = 163
            },
            new () {
                Id = 1156,
                Name = "Borno",
                CountryId = 163
            },
            new () {
                Id = 1157,
                Name = "Cross River",
                CountryId = 163
            },
            new () {
                Id = 1158,
                Name = "Delta",
                CountryId = 163
            },
            new () {
                Id = 1159,
                Name = "Ebonyi",
                CountryId = 163
            },
            new () {
                Id = 1160,
                Name = "Edo",
                CountryId = 163
            },
            new () {
                Id = 1161,
                Name = "Enugu",
                CountryId = 163
            },
            new () {
                Id = 1162,
                Name = "Ekiti",
                CountryId = 163
            },
            new () {
                Id = 1163,
                Name = "FCT",
                CountryId = 163
            },
            new () {
                Id = 1164,
                Name = "Gombe",
                CountryId = 163
            },
            new () {
                Id = 1165,
                Name = "Imo",
                CountryId = 163
            },
            new () {
                Id = 1166,
                Name = "Jigawa",
                CountryId = 163
            },
            new () {
                Id = 1167,
                Name = "Kaduna",
                CountryId = 163
            },
            new () {
                Id = 1168,
                Name = "Kano",
                CountryId = 163
            },
            new () {
                Id = 1169,
                Name = "Katsina",
                CountryId = 163
            },
            new () {
                Id = 1170,
                Name = "Kebbi",
                CountryId = 163
            },
            new () {
                Id = 1171,
                Name = "Kogi",
                CountryId = 163
            },
            new () {
                Id = 1172,
                Name = "Kwara",
                CountryId = 163
            },
            new () {
                Id = 1173,
                Name = "Lagos",
                CountryId = 163
            },
            new () {
                Id = 1174,
                Name = "Nasarawa",
                CountryId = 163
            },
            new () {
                Id = 1175,
                Name = "Niger",
                CountryId = 163
            },
            new () {
                Id = 1176,
                Name = "Ogun",
                CountryId = 163
            },
            new () {
                Id = 1177,
                Name = "Ondo",
                CountryId = 163
            },
            new () {
                Id = 1178,
                Name = "Osun",
                CountryId = 163
            },
            new () {
                Id = 1179,
                Name = "Oyo",
                CountryId = 163
            },
            new () {
                Id = 1180,
                Name = "Plateau",
                CountryId = 163
            },
            new () {
                Id = 1181,
                Name = "Rivers",
                CountryId = 163
            },
            new () {
                Id = 1182,
                Name = "Sokoto",
                CountryId = 163
            },
            new () {
                Id = 1183,
                Name = "Taraba",
                CountryId = 163
            },
            new () {
                Id = 1184,
                Name = "Yobe",
                CountryId = 163
            },
            new () {
                Id = 1185,
                Name = "Zamafara",
                CountryId = 163
            },
        ]
    },
    new() {
        Country = new() { Id = 164, Name = "Niue", TwoLetterIsoCode = "NU", ThreeLetterIsoCode = "NIU" },
    },
    new() {
        Country = new() { Id = 165, Name = "Norfolk Island", TwoLetterIsoCode = "NF", ThreeLetterIsoCode = "NFK" },
    },
    new() {
        Country = new() { Id = 166, Name = "Northern Mariana Islands", TwoLetterIsoCode = "MP", ThreeLetterIsoCode = "MNP" },
    },
    new() {
        Country = new() { Id = 167, Name = "Norway", TwoLetterIsoCode = "NO", ThreeLetterIsoCode = "NOR" },
        StateProvince = [
            new () {
                Id = 1198,
                Name = "Østfold",
                CountryId = 167
            },
            new () {
                Id = 1199,
                Name = "Akershus",
                CountryId = 167
            },
            new () {
                Id = 1200,
                Name = "Oslo",
                CountryId = 167
            },
            new () {
                Id = 1201,
                Name = "Hedmark",
                CountryId = 167
            },
            new () {
                Id = 1202,
                Name = "Oppland",
                CountryId = 167
            },
            new () {
                Id = 1203,
                Name = "Buskerud",
                CountryId = 167
            },
            new () {
                Id = 1204,
                Name = "Vestfold",
                CountryId = 167
            },
            new () {
                Id = 1205,
                Name = "Telemark",
                CountryId = 167
            },
            new () {
                Id = 1206,
                Name = "Aust-Agder",
                CountryId = 167
            },
            new () {
                Id = 1207,
                Name = "Vest-Agder",
                CountryId = 167
            },
            new () {
                Id = 1208,
                Name = "Rogaland",
                CountryId = 167
            },
            new () {
                Id = 1209,
                Name = "Hordaland",
                CountryId = 167
            },
            new () {
                Id = 1210,
                Name = "Sogn og Fjordane",
                CountryId = 167
            },
            new () {
                Id = 1211,
                Name = "Møre og Romsdal",
                CountryId = 167
            },
            new () {
                Id = 1212,
                Name = "Sør-Trøndelag",
                CountryId = 167
            },
            new () {
                Id = 1213,
                Name = "Nord-Trøndelag",
                CountryId = 167
            },
            new () {
                Id = 1214,
                Name = "Nordland",
                CountryId = 167
            },
            new () {
                Id = 1215,
                Name = "Troms",
                CountryId = 167
            },
            new () {
                Id = 1216,
                Name = "Finnmark",
                CountryId = 167
            },
            new () {
                Id = 1217,
                Name = "Svalbard",
                CountryId = 167
            },
            new () {
                Id = 1218,
                Name = "Jan Mayen",
                CountryId = 167
            },
        ]
    },
    new() {
        Country = new() { Id = 168, Name = "Oman", TwoLetterIsoCode = "OM", ThreeLetterIsoCode = "OMN" },
    },
    new() {
        Country = new() { Id = 169, Name = "Pakistan", TwoLetterIsoCode = "PK", ThreeLetterIsoCode = "PAK" },
        StateProvince = [
            new () {
                Id = 1331,
                Name = "Azad Kashmir",
                CountryId = 169
            },
            new () {
                Id = 1332,
                Name = "Balochistan",
                CountryId = 169
            },
            new () {
                Id = 1333,
                Name = "Capital Territory",
                CountryId = 169
            },
            new () {
                Id = 1334,
                Name = "Gilgit–Baltistan",
                CountryId = 169
            },
            new () {
                Id = 1335,
                Name = "Khyber Pakhtunkhwa",
                CountryId = 169
            },
            new () {
                Id = 1336,
                Name = "Punjab",
                CountryId = 169
            },
            new () {
                Id = 1337,
                Name = "Sindh",
                CountryId = 169
            },
            new () {
                Id = 1338,
                Name = "Tribal Areas",
                CountryId = 169
            },
        ]
    },
    new() {
        Country = new() { Id = 170, Name = "Palau", TwoLetterIsoCode = "PW", ThreeLetterIsoCode = "PLW" },
    },
    new() {
        Country = new() { Id = 171, Name = "Palestine, State of", TwoLetterIsoCode = "PS", ThreeLetterIsoCode = "PSE" },
    },
    new() {
        Country = new() { Id = 172, Name = "Panama", TwoLetterIsoCode = "PA", ThreeLetterIsoCode = "PAN" },
    },
    new() {
        Country = new() { Id = 173, Name = "Papua New Guinea", TwoLetterIsoCode = "PG", ThreeLetterIsoCode = "PNG" },
    },
    new() {
        Country = new() { Id = 174, Name = "Paraguay", TwoLetterIsoCode = "PY", ThreeLetterIsoCode = "PRY" },
    },
    new() {
        Country = new() { Id = 175, Name = "Peru", TwoLetterIsoCode = "PE", ThreeLetterIsoCode = "PER" },
    },
    new() {
        Country = new() { Id = 176, Name = "Philippines", TwoLetterIsoCode = "PH", ThreeLetterIsoCode = "PHL" },
        StateProvince = [
            new () {
                Id = 1249,
                Name = "Abra",
                CountryId = 176
            },
            new () {
                Id = 1250,
                Name = "Agusan del Norte",
                CountryId = 176
            },
            new () {
                Id = 1251,
                Name = "Agusan del Sur",
                CountryId = 176
            },
            new () {
                Id = 1252,
                Name = "Aklan",
                CountryId = 176
            },
            new () {
                Id = 1253,
                Name = "Albay",
                CountryId = 176
            },
            new () {
                Id = 1254,
                Name = "Antique",
                CountryId = 176
            },
            new () {
                Id = 1255,
                Name = "Apayao",
                CountryId = 176
            },
            new () {
                Id = 1256,
                Name = "Aurora",
                CountryId = 176
            },
            new () {
                Id = 1257,
                Name = "Basilan",
                CountryId = 176
            },
            new () {
                Id = 1258,
                Name = "Bataan",
                CountryId = 176
            },
            new () {
                Id = 1259,
                Name = "Batanes",
                CountryId = 176
            },
            new () {
                Id = 1260,
                Name = "Batangas",
                CountryId = 176
            },
            new () {
                Id = 1261,
                Name = "Benguet",
                CountryId = 176
            },
            new () {
                Id = 1262,
                Name = "Biliran",
                CountryId = 176
            },
            new () {
                Id = 1263,
                Name = "Bohol",
                CountryId = 176
            },
            new () {
                Id = 1264,
                Name = "Bukidnon",
                CountryId = 176
            },
            new () {
                Id = 1265,
                Name = "Bulacan",
                CountryId = 176
            },
            new () {
                Id = 1266,
                Name = "Cagayan",
                CountryId = 176
            },
            new () {
                Id = 1267,
                Name = "Camarines Norte",
                CountryId = 176
            },
            new () {
                Id = 1268,
                Name = "Camarines Sur",
                CountryId = 176
            },
            new () {
                Id = 1269,
                Name = "Camiguin",
                CountryId = 176
            },
            new () {
                Id = 1270,
                Name = "Capiz",
                CountryId = 176
            },
            new () {
                Id = 1271,
                Name = "Catanduanes",
                CountryId = 176
            },
            new () {
                Id = 1272,
                Name = "Cavite",
                CountryId = 176
            },
            new () {
                Id = 1273,
                Name = "Cebu",
                CountryId = 176
            },
            new () {
                Id = 1274,
                Name = "Compostela Valley",
                CountryId = 176
            },
            new () {
                Id = 1275,
                Name = "Cotabato",
                CountryId = 176
            },
            new () {
                Id = 1276,
                Name = "Davao del Norte",
                CountryId = 176
            },
            new () {
                Id = 1277,
                Name = "Davao del Sur",
                CountryId = 176
            },
            new () {
                Id = 1278,
                Name = "Davao Occidental",
                CountryId = 176
            },
            new () {
                Id = 1279,
                Name = "Davao Oriental",
                CountryId = 176
            },
            new () {
                Id = 1280,
                Name = "Dinagat Islands",
                CountryId = 176
            },
            new () {
                Id = 1281,
                Name = "Eastern Samar",
                CountryId = 176
            },
            new () {
                Id = 1282,
                Name = "Guimaras",
                CountryId = 176
            },
            new () {
                Id = 1283,
                Name = "Ifugao",
                CountryId = 176
            },
            new () {
                Id = 1284,
                Name = "Ilocos Norte",
                CountryId = 176
            },
            new () {
                Id = 1285,
                Name = "Ilocos Sur",
                CountryId = 176
            },
            new () {
                Id = 1286,
                Name = "Iloilo",
                CountryId = 176
            },
            new () {
                Id = 1287,
                Name = "Isabela",
                CountryId = 176
            },
            new () {
                Id = 1288,
                Name = "Kalinga",
                CountryId = 176
            },
            new () {
                Id = 1289,
                Name = "La Union",
                CountryId = 176
            },
            new () {
                Id = 1290,
                Name = "Laguna",
                CountryId = 176
            },
            new () {
                Id = 1291,
                Name = "Lanao del Norte",
                CountryId = 176
            },
            new () {
                Id = 1292,
                Name = "Lanao del Sur",
                CountryId = 176
            },
            new () {
                Id = 1293,
                Name = "Leyte",
                CountryId = 176
            },
            new () {
                Id = 1294,
                Name = "Maguindanao",
                CountryId = 176
            },
            new () {
                Id = 1295,
                Name = "Marinduque",
                CountryId = 176
            },
            new () {
                Id = 1296,
                Name = "Masbate",
                CountryId = 176
            },
            new () {
                Id = 1297,
                Name = "Misamis Occidental",
                CountryId = 176
            },
            new () {
                Id = 1298,
                Name = "Misamis Oriental",
                CountryId = 176
            },
            new () {
                Id = 1299,
                Name = "Mountain Province",
                CountryId = 176
            },
            new () {
                Id = 1300,
                Name = "Negros Occidental",
                CountryId = 176
            },
            new () {
                Id = 1301,
                Name = "Negros Oriental",
                CountryId = 176
            },
            new () {
                Id = 1302,
                Name = "Northern Samar",
                CountryId = 176
            },
            new () {
                Id = 1303,
                Name = "Nueva Ecija",
                CountryId = 176
            },
            new () {
                Id = 1304,
                Name = "Nueva Vizcaya",
                CountryId = 176
            },
            new () {
                Id = 1305,
                Name = "Occidental Mindoro",
                CountryId = 176
            },
            new () {
                Id = 1306,
                Name = "Oriental Mindoro",
                CountryId = 176
            },
            new () {
                Id = 1307,
                Name = "Palawan",
                CountryId = 176
            },
            new () {
                Id = 1308,
                Name = "Pampanga",
                CountryId = 176
            },
            new () {
                Id = 1309,
                Name = "Pangasinan",
                CountryId = 176
            },
            new () {
                Id = 1310,
                Name = "Quezon",
                CountryId = 176
            },
            new () {
                Id = 1311,
                Name = "Quirino",
                CountryId = 176
            },
            new () {
                Id = 1312,
                Name = "Rizal",
                CountryId = 176
            },
            new () {
                Id = 1313,
                Name = "Romblon",
                CountryId = 176
            },
            new () {
                Id = 1314,
                Name = "Samar",
                CountryId = 176
            },
            new () {
                Id = 1315,
                Name = "Sarangani",
                CountryId = 176
            },
            new () {
                Id = 1316,
                Name = "Siquijor",
                CountryId = 176
            },
            new () {
                Id = 1317,
                Name = "Sorsogon",
                CountryId = 176
            },
            new () {
                Id = 1318,
                Name = "South Cotabato",
                CountryId = 176
            },
            new () {
                Id = 1319,
                Name = "Southern Leyte",
                CountryId = 176
            },
            new () {
                Id = 1320,
                Name = "Sultan Kudarat",
                CountryId = 176
            },
            new () {
                Id = 1321,
                Name = "Sulu",
                CountryId = 176
            },
            new () {
                Id = 1322,
                Name = "Surigao del Norte",
                CountryId = 176
            },
            new () {
                Id = 1323,
                Name = "Surigao del Sur",
                CountryId = 176
            },
            new () {
                Id = 1324,
                Name = "Tarlac",
                CountryId = 176
            },
            new () {
                Id = 1325,
                Name = "Tawi-Tawi",
                CountryId = 176
            },
            new () {
                Id = 1326,
                Name = "Zambales",
                CountryId = 176
            },
            new () {
                Id = 1327,
                Name = "Zamboanga del Norte",
                CountryId = 176
            },
            new () {
                Id = 1328,
                Name = "Zamboanga del Sur",
                CountryId = 176
            },
            new () {
                Id = 1329,
                Name = "Zamboanga Sibugay",
                CountryId = 176
            },
            new () {
                Id = 1330,
                Name = "Metro Manila",
                CountryId = 176
            },
        ]
    },
    new() {
        Country = new() { Id = 177, Name = "Pitcairn", TwoLetterIsoCode = "PN", ThreeLetterIsoCode = "PCN" },
    },
    new() {
        Country = new() { Id = 178, Name = "Poland", TwoLetterIsoCode = "PL", ThreeLetterIsoCode = "POL" },
        StateProvince = [
            new () {
                Id = 1339,
                Name = "Dolnośląskie",
                CountryId = 178
            },
            new () {
                Id = 1340,
                Name = "Kujawsko-pomorskie",
                CountryId = 178
            },
            new () {
                Id = 1341,
                Name = "Lubelskie",
                CountryId = 178
            },
            new () {
                Id = 1342,
                Name = "Lubuskie",
                CountryId = 178
            },
            new () {
                Id = 1343,
                Name = "Łódzkie",
                CountryId = 178
            },
            new () {
                Id = 1344,
                Name = "Małopolskie",
                CountryId = 178
            },
            new () {
                Id = 1345,
                Name = "Mazowieckie",
                CountryId = 178
            },
            new () {
                Id = 1346,
                Name = "Opolskie",
                CountryId = 178
            },
            new () {
                Id = 1347,
                Name = "Podkarpackie",
                CountryId = 178
            },
            new () {
                Id = 1348,
                Name = "Podlaskie",
                CountryId = 178
            },
            new () {
                Id = 1349,
                Name = "Pomorskie",
                CountryId = 178
            },
            new () {
                Id = 1350,
                Name = "Śląskie",
                CountryId = 178
            },
            new () {
                Id = 1351,
                Name = "Świętokrzyskie",
                CountryId = 178
            },
            new () {
                Id = 1352,
                Name = "Warmińsko-mazurskie",
                CountryId = 178
            },
            new () {
                Id = 1353,
                Name = "Wielkopolskie",
                CountryId = 178
            },
            new () {
                Id = 1354,
                Name = "Zachodniopomorskie",
                CountryId = 178
            },
        ]
    },
    new() {
        Country = new() { Id = 179, Name = "Portugal", TwoLetterIsoCode = "PT", ThreeLetterIsoCode = "PRT" },
        StateProvince = [
            new () {
                Id = 1355,
                Name = "Aveiro",
                CountryId = 179
            },
            new () {
                Id = 1356,
                Name = "Beja",
                CountryId = 179
            },
            new () {
                Id = 1357,
                Name = "Braga",
                CountryId = 179
            },
            new () {
                Id = 1358,
                Name = "Bragança",
                CountryId = 179
            },
            new () {
                Id = 1359,
                Name = "Castelo Branco",
                CountryId = 179
            },
            new () {
                Id = 1360,
                Name = "Coimbra",
                CountryId = 179
            },
            new () {
                Id = 1361,
                Name = "Évora",
                CountryId = 179
            },
            new () {
                Id = 1362,
                Name = "Faro",
                CountryId = 179
            },
            new () {
                Id = 1363,
                Name = "Guarda",
                CountryId = 179
            },
            new () {
                Id = 1364,
                Name = "Leiria",
                CountryId = 179
            },
            new () {
                Id = 1365,
                Name = "Lisboa",
                CountryId = 179
            },
            new () {
                Id = 1366,
                Name = "Portalegre",
                CountryId = 179
            },
            new () {
                Id = 1367,
                Name = "Porto",
                CountryId = 179
            },
            new () {
                Id = 1368,
                Name = "Santarém",
                CountryId = 179
            },
            new () {
                Id = 1369,
                Name = "Setúbal",
                CountryId = 179
            },
            new () {
                Id = 1370,
                Name = "Viana do Castelo",
                CountryId = 179
            },
            new () {
                Id = 1371,
                Name = "Vila Real",
                CountryId = 179
            },
            new () {
                Id = 1372,
                Name = "Viseu",
                CountryId = 179
            },
            new () {
                Id = 1373,
                Name = "Região Autónoma dos Açores",
                CountryId = 179
            },
            new () {
                Id = 1374,
                Name = "Região Autónoma da Madeira",
                CountryId = 179
            },
        ]
    },
    new() {
        Country = new() { Id = 180, Name = "Puerto Rico", TwoLetterIsoCode = "PR", ThreeLetterIsoCode = "PRI" },
    },
    new() {
        Country = new() { Id = 181, Name = "Qatar", TwoLetterIsoCode = "QA", ThreeLetterIsoCode = "QAT" },
    },
    new() {
        Country = new() { Id = 182, Name = "Réunion", TwoLetterIsoCode = "RE", ThreeLetterIsoCode = "REU" },
    },
    new() {
        Country = new() { Id = 183, Name = "Romania", TwoLetterIsoCode = "RO", ThreeLetterIsoCode = "ROU" },
        StateProvince = [
            new () {
                Id = 1375,
                Name = "Alba",
                CountryId = 183
            },
            new () {
                Id = 1376,
                Name = "Arad",
                CountryId = 183
            },
            new () {
                Id = 1377,
                Name = "Argeș",
                CountryId = 183
            },
            new () {
                Id = 1378,
                Name = "Bacău",
                CountryId = 183
            },
            new () {
                Id = 1379,
                Name = "Bihor",
                CountryId = 183
            },
            new () {
                Id = 1380,
                Name = "Bistrița-Năsăud",
                CountryId = 183
            },
            new () {
                Id = 1381,
                Name = "Botoșani",
                CountryId = 183
            },
            new () {
                Id = 1382,
                Name = "Brașov",
                CountryId = 183
            },
            new () {
                Id = 1383,
                Name = "Brăila",
                CountryId = 183
            },
            new () {
                Id = 1384,
                Name = "București Sector 1",
                CountryId = 183
            },
            new () {
                Id = 1385,
                Name = "București Sector 2",
                CountryId = 183
            },
            new () {
                Id = 1386,
                Name = "București Sector 3",
                CountryId = 183
            },
            new () {
                Id = 1387,
                Name = "București Sector 4",
                CountryId = 183
            },
            new () {
                Id = 1388,
                Name = "București Sector 5",
                CountryId = 183
            },
            new () {
                Id = 1389,
                Name = "București Sector 6",
                CountryId = 183
            },
            new () {
                Id = 1390,
                Name = "Buzău",
                CountryId = 183
            },
            new () {
                Id = 1391,
                Name = "Caraș-Severin",
                CountryId = 183
            },
            new () {
                Id = 1392,
                Name = "Călărași",
                CountryId = 183
            },
            new () {
                Id = 1393,
                Name = "Cluj",
                CountryId = 183
            },
            new () {
                Id = 1394,
                Name = "Constanța",
                CountryId = 183
            },
            new () {
                Id = 1395,
                Name = "Covasna",
                CountryId = 183
            },
            new () {
                Id = 1396,
                Name = "Dâmbovița",
                CountryId = 183
            },
            new () {
                Id = 1397,
                Name = "Dolj",
                CountryId = 183
            },
            new () {
                Id = 1398,
                Name = "Galați",
                CountryId = 183
            },
            new () {
                Id = 1399,
                Name = "Giurgiu",
                CountryId = 183
            },
            new () {
                Id = 1400,
                Name = "Gorj",
                CountryId = 183
            },
            new () {
                Id = 1401,
                Name = "Harghita",
                CountryId = 183
            },
            new () {
                Id = 1402,
                Name = "Hunedoara",
                CountryId = 183
            },
            new () {
                Id = 1403,
                Name = "Ialomița",
                CountryId = 183
            },
            new () {
                Id = 1404,
                Name = "Iași",
                CountryId = 183
            },
            new () {
                Id = 1405,
                Name = "Ilfov",
                CountryId = 183
            },
            new () {
                Id = 1406,
                Name = "Maramureș",
                CountryId = 183
            },
            new () {
                Id = 1407,
                Name = "Mehedinți",
                CountryId = 183
            },
            new () {
                Id = 1408,
                Name = "Mureș",
                CountryId = 183
            },
            new () {
                Id = 1409,
                Name = "Neamț",
                CountryId = 183
            },
            new () {
                Id = 1410,
                Name = "Olt",
                CountryId = 183
            },
            new () {
                Id = 1411,
                Name = "Prahova",
                CountryId = 183
            },
            new () {
                Id = 1412,
                Name = "Satu Mare",
                CountryId = 183
            },
            new () {
                Id = 1413,
                Name = "Sălaj",
                CountryId = 183
            },
            new () {
                Id = 1414,
                Name = "Sibiu",
                CountryId = 183
            },
            new () {
                Id = 1415,
                Name = "Suceava",
                CountryId = 183
            },
            new () {
                Id = 1416,
                Name = "Teleorman",
                CountryId = 183
            },
            new () {
                Id = 1417,
                Name = "Timiș",
                CountryId = 183
            },
            new () {
                Id = 1418,
                Name = "Tulcea",
                CountryId = 183
            },
            new () {
                Id = 1419,
                Name = "Vaslui",
                CountryId = 183
            },
            new () {
                Id = 1420,
                Name = "Vâlcea",
                CountryId = 183
            },
            new () {
                Id = 1421,
                Name = "Vrancea",
                CountryId = 183
            },
        ]
    },
    new() {
        Country = new() { Id = 184, Name = "Russian Federation", TwoLetterIsoCode = "RU", ThreeLetterIsoCode = "RUS" },
        StateProvince = [
            new () {
                Id = 1425,
                Name = "Адыгея",
                CountryId = 184
            },
            new () {
                Id = 1426,
                Name = "Алтай",
                CountryId = 184
            },
            new () {
                Id = 1427,
                Name = "Алтайский край",
                CountryId = 184
            },
            new () {
                Id = 1428,
                Name = "Амурская область",
                CountryId = 184
            },
            new () {
                Id = 1429,
                Name = "Архангельская область",
                CountryId = 184
            },
            new () {
                Id = 1430,
                Name = "Астраханская область",
                CountryId = 184
            },
            new () {
                Id = 1431,
                Name = "Башкортостан",
                CountryId = 184
            },
            new () {
                Id = 1432,
                Name = "Белгородская область",
                CountryId = 184
            },
            new () {
                Id = 1433,
                Name = "Брянская область",
                CountryId = 184
            },
            new () {
                Id = 1434,
                Name = "Бурятия",
                CountryId = 184
            },
            new () {
                Id = 1435,
                Name = "Владимирская область",
                CountryId = 184
            },
            new () {
                Id = 1436,
                Name = "Волгоградская область",
                CountryId = 184
            },
            new () {
                Id = 1437,
                Name = "Вологодская область",
                CountryId = 184
            },
            new () {
                Id = 1438,
                Name = "Воронежская область",
                CountryId = 184
            },
            new () {
                Id = 1439,
                Name = "Дагестан",
                CountryId = 184
            },
            new () {
                Id = 1440,
                Name = "Еврейская автономная область",
                CountryId = 184
            },
            new () {
                Id = 1441,
                Name = "Забайкальский край",
                CountryId = 184
            },
            new () {
                Id = 1442,
                Name = "Ивановская область",
                CountryId = 184
            },
            new () {
                Id = 1443,
                Name = "Ингушетия",
                CountryId = 184
            },
            new () {
                Id = 1444,
                Name = "Иркутская область",
                CountryId = 184
            },
            new () {
                Id = 1445,
                Name = "Кабардино-Балкарская Республика",
                CountryId = 184
            },
            new () {
                Id = 1446,
                Name = "Калининградская область",
                CountryId = 184
            },
            new () {
                Id = 1447,
                Name = "Калмыкия",
                CountryId = 184
            },
            new () {
                Id = 1448,
                Name = "Калужская область",
                CountryId = 184
            },
            new () {
                Id = 1449,
                Name = "Камчатский край",
                CountryId = 184
            },
            new () {
                Id = 1450,
                Name = "Карачаево-Черкесская Республика",
                CountryId = 184
            },
            new () {
                Id = 1451,
                Name = "Карелия",
                CountryId = 184
            },
            new () {
                Id = 1452,
                Name = "Кемеровская область",
                CountryId = 184
            },
            new () {
                Id = 1453,
                Name = "Кировская область",
                CountryId = 184
            },
            new () {
                Id = 1454,
                Name = "Коми",
                CountryId = 184
            },
            new () {
                Id = 1455,
                Name = "Костромская область",
                CountryId = 184
            },
            new () {
                Id = 1456,
                Name = "Краснодарский край",
                CountryId = 184
            },
            new () {
                Id = 1457,
                Name = "Красноярский край",
                CountryId = 184
            },
            new () {
                Id = 1458,
                Name = "Крым",
                CountryId = 184
            },
            new () {
                Id = 1459,
                Name = "Курганская область",
                CountryId = 184
            },
            new () {
                Id = 1460,
                Name = "Курская область",
                CountryId = 184
            },
            new () {
                Id = 1461,
                Name = "Ленинградская область",
                CountryId = 184
            },
            new () {
                Id = 1462,
                Name = "Липецкая область",
                CountryId = 184
            },
            new () {
                Id = 1463,
                Name = "Магаданская область",
                CountryId = 184
            },
            new () {
                Id = 1464,
                Name = "Марий Эл",
                CountryId = 184
            },
            new () {
                Id = 1465,
                Name = "Мордовия",
                CountryId = 184
            },
            new () {
                Id = 1466,
                Name = "Москва",
                CountryId = 184
            },
            new () {
                Id = 1467,
                Name = "Московская область",
                CountryId = 184
            },
            new () {
                Id = 1468,
                Name = "Мурманская область",
                CountryId = 184
            },
            new () {
                Id = 1469,
                Name = "Ненецкий автономный округ",
                CountryId = 184
            },
            new () {
                Id = 1470,
                Name = "Нижегородская область",
                CountryId = 184
            },
            new () {
                Id = 1471,
                Name = "Новгородская область",
                CountryId = 184
            },
            new () {
                Id = 1472,
                Name = "Новосибирская область",
                CountryId = 184
            },
            new () {
                Id = 1473,
                Name = "Омская область",
                CountryId = 184
            },
            new () {
                Id = 1474,
                Name = "Оренбургская область",
                CountryId = 184
            },
            new () {
                Id = 1475,
                Name = "Орловская область",
                CountryId = 184
            },
            new () {
                Id = 1476,
                Name = "Пензенская область",
                CountryId = 184
            },
            new () {
                Id = 1477,
                Name = "Пермский край",
                CountryId = 184
            },
            new () {
                Id = 1478,
                Name = "Приморский край",
                CountryId = 184
            },
            new () {
                Id = 1479,
                Name = "Псковская область",
                CountryId = 184
            },
            new () {
                Id = 1480,
                Name = "Ростовская область",
                CountryId = 184
            },
            new () {
                Id = 1481,
                Name = "Рязанская область",
                CountryId = 184
            },
            new () {
                Id = 1482,
                Name = "Самарская область",
                CountryId = 184
            },
            new () {
                Id = 1483,
                Name = "Санкт-Петербург",
                CountryId = 184
            },
            new () {
                Id = 1484,
                Name = "Саратовская область",
                CountryId = 184
            },
            new () {
                Id = 1485,
                Name = "Саха (Якутия)",
                CountryId = 184
            },
            new () {
                Id = 1486,
                Name = "Сахалинская область",
                CountryId = 184
            },
            new () {
                Id = 1487,
                Name = "Свердловская область",
                CountryId = 184
            },
            new () {
                Id = 1488,
                Name = "Севастополь",
                CountryId = 184
            },
            new () {
                Id = 1489,
                Name = "Северная Осетия-Алания",
                CountryId = 184
            },
            new () {
                Id = 1490,
                Name = "Смоленская область",
                CountryId = 184
            },
            new () {
                Id = 1491,
                Name = "Ставропольский край",
                CountryId = 184
            },
            new () {
                Id = 1492,
                Name = "Тамбовская область",
                CountryId = 184
            },
            new () {
                Id = 1493,
                Name = "Татарстан",
                CountryId = 184
            },
            new () {
                Id = 1494,
                Name = "Тверская область",
                CountryId = 184
            },
            new () {
                Id = 1495,
                Name = "Томская область",
                CountryId = 184
            },
            new () {
                Id = 1496,
                Name = "Тульская область",
                CountryId = 184
            },
            new () {
                Id = 1497,
                Name = "Тыва",
                CountryId = 184
            },
            new () {
                Id = 1498,
                Name = "Тюменская область",
                CountryId = 184
            },
            new () {
                Id = 1499,
                Name = "Удмуртская Республика",
                CountryId = 184
            },
            new () {
                Id = 1500,
                Name = "Ульяновская область",
                CountryId = 184
            },
            new () {
                Id = 1501,
                Name = "Хабаровский край",
                CountryId = 184
            },
            new () {
                Id = 1502,
                Name = "Хакасия",
                CountryId = 184
            },
            new () {
                Id = 1503,
                Name = "Ханты-Мансийский автономный округ-Югра",
                CountryId = 184
            },
            new () {
                Id = 1504,
                Name = "Челябинская область",
                CountryId = 184
            },
            new () {
                Id = 1505,
                Name = "Чеченская Республика",
                CountryId = 184
            },
            new () {
                Id = 1506,
                Name = "Чувашская Республика",
                CountryId = 184
            },
            new () {
                Id = 1507,
                Name = "Чукотский автономный округ",
                CountryId = 184
            },
            new () {
                Id = 1508,
                Name = "Ямало-Ненецкий автономный округ",
                CountryId = 184
            },
            new () {
                Id = 1509,
                Name = "Ярославская область",
                CountryId = 184
            },
        ]
    },
    new() {
        Country = new() { Id = 185, Name = "Rwanda", TwoLetterIsoCode = "RW", ThreeLetterIsoCode = "RWA" },
    },
    new() {
        Country = new() { Id = 186, Name = "Saint Barthélemy", TwoLetterIsoCode = "BL", ThreeLetterIsoCode = "BLM" },
    },
    new() {
        Country = new() { Id = 187, Name = "Saint Helena, Ascension and Tristan da Cunha", TwoLetterIsoCode = "SH", ThreeLetterIsoCode = "SHN" },
    },
    new() {
        Country = new() { Id = 188, Name = "Saint Kitts and Nevis", TwoLetterIsoCode = "KN", ThreeLetterIsoCode = "KNA" },
    },
    new() {
        Country = new() { Id = 189, Name = "Saint Lucia", TwoLetterIsoCode = "LC", ThreeLetterIsoCode = "LCA" },
    },
    new() {
        Country = new() { Id = 190, Name = "Saint Martin (French part)", TwoLetterIsoCode = "MF", ThreeLetterIsoCode = "MAF" },
    },
    new() {
        Country = new() { Id = 191, Name = "Saint Pierre and Miquelon", TwoLetterIsoCode = "PM", ThreeLetterIsoCode = "SPM" },
    },
    new() {
        Country = new() { Id = 192, Name = "Saint Vincent and the Grenadines", TwoLetterIsoCode = "VC", ThreeLetterIsoCode = "VCT" },
    },
    new() {
        Country = new() { Id = 193, Name = "Samoa", TwoLetterIsoCode = "WS", ThreeLetterIsoCode = "WSM" },
    },
    new() {
        Country = new() { Id = 194, Name = "San Marino", TwoLetterIsoCode = "SP", ThreeLetterIsoCode = "SMR" },
    },
    new() {
        Country = new() { Id = 195, Name = "Sao Tome and Principe", TwoLetterIsoCode = "ST", ThreeLetterIsoCode = "STP" },
    },
    new() {
        Country = new() { Id = 196, Name = "Saudi Arabia", TwoLetterIsoCode = "SA", ThreeLetterIsoCode = "SAU" },
        StateProvince = [
            new () {
                Id = 1510,
                Name = "Eastern Cape",
                CountryId = 196
            },
            new () {
                Id = 1511,
                Name = "Al Bahah",
                CountryId = 196
            },
            new () {
                Id = 1512,
                Name = "Al Jawf",
                CountryId = 196
            },
            new () {
                Id = 1513,
                Name = "Al Madinah",
                CountryId = 196
            },
            new () {
                Id = 1514,
                Name = "Al Qasim",
                CountryId = 196
            },
            new () {
                Id = 1515,
                Name = "Al Riyadh",
                CountryId = 196
            },
            new () {
                Id = 1516,
                Name = "Asir",
                CountryId = 196
            },
            new () {
                Id = 1517,
                Name = "Eastern Province",
                CountryId = 196
            },
            new () {
                Id = 1518,
                Name = "Ha'il",
                CountryId = 196
            },
            new () {
                Id = 1519,
                Name = "Jizan",
                CountryId = 196
            },
            new () {
                Id = 1520,
                Name = "Makkah",
                CountryId = 196
            },
            new () {
                Id = 1521,
                Name = "Najran",
                CountryId = 196
            },
            new () {
                Id = 1522,
                Name = "Northern Borders",
                CountryId = 196
            },
            new () {
                Id = 1523,
                Name = "Tabuk",
                CountryId = 196
            },
        ]
    },
    new() {
        Country = new() { Id = 197, Name = "Senegal", TwoLetterIsoCode = "SN", ThreeLetterIsoCode = "SEN" },
    },
    new() {
        Country = new() { Id = 198, Name = "Serbia", TwoLetterIsoCode = "RS", ThreeLetterIsoCode = "SRB" },
        StateProvince = [
            new () {
                Id = 1422,
                Name = "Serbia",
                CountryId = 198
            },
            new () {
                Id = 1423,
                Name = "Kosovo",
                CountryId = 198
            },
            new () {
                Id = 1424,
                Name = "Vojvodina",
                CountryId = 198
            },
        ]
    },
    new() {
        Country = new() { Id = 199, Name = "Seychelles", TwoLetterIsoCode = "SC", ThreeLetterIsoCode = "SYC" },
    },
    new() {
        Country = new() { Id = 200, Name = "Sierra Leone", TwoLetterIsoCode = "SL", ThreeLetterIsoCode = "SLE" },
    },
    new() {
        Country = new() { Id = 201, Name = "Singapore", TwoLetterIsoCode = "SG", ThreeLetterIsoCode = "SGP" },
    },
    new() {
        Country = new() { Id = 202, Name = "Sint Maarten (Dutch part)", TwoLetterIsoCode = "SX", ThreeLetterIsoCode = "SXM" },
    },
    new() {
        Country = new() { Id = 203, Name = "Slovakia", TwoLetterIsoCode = "SK", ThreeLetterIsoCode = "SVK" },
        StateProvince = [
            new () {
                Id = 1557,
                Name = "Bratislavský kraj",
                CountryId = 203
            },
            new () {
                Id = 1558,
                Name = "Trnavský kraj",
                CountryId = 203
            },
            new () {
                Id = 1559,
                Name = "Nitrianský kraj",
                CountryId = 203
            },
            new () {
                Id = 1560,
                Name = "Trenčianský kraj",
                CountryId = 203
            },
            new () {
                Id = 1561,
                Name = "Žilinský kraj",
                CountryId = 203
            },
            new () {
                Id = 1562,
                Name = "Banskobystrický kraj",
                CountryId = 203
            },
            new () {
                Id = 1563,
                Name = "Košický kraj",
                CountryId = 203
            },
            new () {
                Id = 1564,
                Name = "Prešovský kraj",
                CountryId = 203
            },
        ]
    },
    new() {
        Country = new() { Id = 204, Name = "Slovenia", TwoLetterIsoCode = "SI", ThreeLetterIsoCode = "SVN" },
        StateProvince = [
            new () {
                Id = 1545,
                Name = "Pomurska",
                CountryId = 204
            },
            new () {
                Id = 1546,
                Name = "Podravska",
                CountryId = 204
            },
            new () {
                Id = 1547,
                Name = "Koroška",
                CountryId = 204
            },
            new () {
                Id = 1548,
                Name = "Savinjska",
                CountryId = 204
            },
            new () {
                Id = 1549,
                Name = "Zasavska",
                CountryId = 204
            },
            new () {
                Id = 1550,
                Name = "Posavska",
                CountryId = 204
            },
            new () {
                Id = 1551,
                Name = "Jugovzhodna Slovenija",
                CountryId = 204
            },
            new () {
                Id = 1552,
                Name = "Primorsko-notranjska",
                CountryId = 204
            },
            new () {
                Id = 1553,
                Name = "Osrednjeslovenska",
                CountryId = 204
            },
            new () {
                Id = 1554,
                Name = "Gorenjska",
                CountryId = 204
            },
            new () {
                Id = 1555,
                Name = "Goriška",
                CountryId = 204
            },
            new () {
                Id = 1556,
                Name = "Obalno-kraška",
                CountryId = 204
            },
        ]
    },
    new() {
        Country = new() { Id = 205, Name = "Solomon Islands", TwoLetterIsoCode = "SB", ThreeLetterIsoCode = "SLB" },
    },
    new() {
        Country = new() { Id = 206, Name = "Somalia", TwoLetterIsoCode = "SO", ThreeLetterIsoCode = "SOM" },
    },
    new() {
        Country = new() { Id = 207, Name = "South Africa", TwoLetterIsoCode = "ZA", ThreeLetterIsoCode = "ZAF" },
        StateProvince = [
            new () {
                Id = 1819,
                Name = "Free State",
                CountryId = 207
            },
            new () {
                Id = 1820,
                Name = "Gauteng",
                CountryId = 207
            },
            new () {
                Id = 1821,
                Name = "KwaZulu-Natal",
                CountryId = 207
            },
            new () {
                Id = 1822,
                Name = "Limpopo",
                CountryId = 207
            },
            new () {
                Id = 1823,
                Name = "Mpumalanga",
                CountryId = 207
            },
            new () {
                Id = 1824,
                Name = "Northern Cape",
                CountryId = 207
            },
            new () {
                Id = 1825,
                Name = "North West",
                CountryId = 207
            },
            new () {
                Id = 1826,
                Name = "Western Cape",
                CountryId = 207
            },
        ]
    },
    new() {
        Country = new() { Id = 208, Name = "South Georgia and the South Sandwich Islands", TwoLetterIsoCode = "GS", ThreeLetterIsoCode = "SGS" },
    },
    new() {
        Country = new() { Id = 209, Name = "South Sudan", TwoLetterIsoCode = "SS", ThreeLetterIsoCode = "SSD" },
    },
    new() {
        Country = new() { Id = 210, Name = "Spain", TwoLetterIsoCode = "ES", ThreeLetterIsoCode = "ESP" },
        StateProvince = [
            new () {
                Id = 404,
                Name = "Álava",
                CountryId = 210
            },
            new () {
                Id = 405,
                Name = "Albacete",
                CountryId = 210
            },
            new () {
                Id = 406,
                Name = "Alicante",
                CountryId = 210
            },
            new () {
                Id = 407,
                Name = "Almería",
                CountryId = 210
            },
            new () {
                Id = 408,
                Name = "Ávila",
                CountryId = 210
            },
            new () {
                Id = 409,
                Name = "Badajoz",
                CountryId = 210
            },
            new () {
                Id = 410,
                Name = "Baleares (Illes)",
                CountryId = 210
            },
            new () {
                Id = 411,
                Name = "Barcelona",
                CountryId = 210
            },
            new () {
                Id = 412,
                Name = "Burgos",
                CountryId = 210
            },
            new () {
                Id = 413,
                Name = "Cáceres",
                CountryId = 210
            },
            new () {
                Id = 414,
                Name = "Cádiz",
                CountryId = 210
            },
            new () {
                Id = 415,
                Name = "Castellón",
                CountryId = 210
            },
            new () {
                Id = 416,
                Name = "Ciudad Real",
                CountryId = 210
            },
            new () {
                Id = 417,
                Name = "Córdoba",
                CountryId = 210
            },
            new () {
                Id = 418,
                Name = "A Coruña",
                CountryId = 210
            },
            new () {
                Id = 419,
                Name = "Cuenca",
                CountryId = 210
            },
            new () {
                Id = 420,
                Name = "Girona",
                CountryId = 210
            },
            new () {
                Id = 421,
                Name = "Granada",
                CountryId = 210
            },
            new () {
                Id = 422,
                Name = "Guadalajara",
                CountryId = 210
            },
            new () {
                Id = 423,
                Name = "Guipúzcoa",
                CountryId = 210
            },
            new () {
                Id = 424,
                Name = "Huelva",
                CountryId = 210
            },
            new () {
                Id = 425,
                Name = "Huesca",
                CountryId = 210
            },
            new () {
                Id = 426,
                Name = "Jaén",
                CountryId = 210
            },
            new () {
                Id = 427,
                Name = "León",
                CountryId = 210
            },
            new () {
                Id = 428,
                Name = "Lleida",
                CountryId = 210
            },
            new () {
                Id = 429,
                Name = "La Rioja",
                CountryId = 210
            },
            new () {
                Id = 430,
                Name = "Lugo",
                CountryId = 210
            },
            new () {
                Id = 431,
                Name = "Madrid",
                CountryId = 210
            },
            new () {
                Id = 432,
                Name = "Málaga",
                CountryId = 210
            },
            new () {
                Id = 433,
                Name = "Murcia",
                CountryId = 210
            },
            new () {
                Id = 434,
                Name = "Navarra",
                CountryId = 210
            },
            new () {
                Id = 435,
                Name = "Ourense",
                CountryId = 210
            },
            new () {
                Id = 436,
                Name = "Asturias",
                CountryId = 210
            },
            new () {
                Id = 437,
                Name = "Palencia",
                CountryId = 210
            },
            new () {
                Id = 438,
                Name = "Las Palmas",
                CountryId = 210
            },
            new () {
                Id = 439,
                Name = "Pontevedra",
                CountryId = 210
            },
            new () {
                Id = 440,
                Name = "Salamanca",
                CountryId = 210
            },
            new () {
                Id = 441,
                Name = "Santa Cruz de Tenerife",
                CountryId = 210
            },
            new () {
                Id = 442,
                Name = "Cantabria",
                CountryId = 210
            },
            new () {
                Id = 443,
                Name = "Segovia",
                CountryId = 210
            },
            new () {
                Id = 444,
                Name = "Sevilla",
                CountryId = 210
            },
            new () {
                Id = 445,
                Name = "Soria",
                CountryId = 210
            },
            new () {
                Id = 446,
                Name = "Tarragona",
                CountryId = 210
            },
            new () {
                Id = 447,
                Name = "Teruel",
                CountryId = 210
            },
            new () {
                Id = 448,
                Name = "Toledo",
                CountryId = 210
            },
            new () {
                Id = 449,
                Name = "Valencia",
                CountryId = 210
            },
            new () {
                Id = 450,
                Name = "Valladolid",
                CountryId = 210
            },
            new () {
                Id = 451,
                Name = "Vizcaya",
                CountryId = 210
            },
            new () {
                Id = 452,
                Name = "Zamora",
                CountryId = 210
            },
            new () {
                Id = 453,
                Name = "Zaragoza",
                CountryId = 210
            },
            new () {
                Id = 454,
                Name = "Ceuta",
                CountryId = 210
            },
            new () {
                Id = 455,
                Name = "Melilla",
                CountryId = 210
            },
        ]
    },
    new() {
        Country = new() { Id = 211, Name = "Sri Lanka", TwoLetterIsoCode = "LK", ThreeLetterIsoCode = "LKA" },
    },
    new() {
        Country = new() { Id = 212, Name = "Sudan", TwoLetterIsoCode = "SD", ThreeLetterIsoCode = "SDN" },
    },
    new() {
        Country = new() { Id = 213, Name = "Suriname", TwoLetterIsoCode = "SR", ThreeLetterIsoCode = "SUR" },
    },
    new() {
        Country = new() { Id = 214, Name = "Svalbard and Jan Mayen", TwoLetterIsoCode = "SJ", ThreeLetterIsoCode = "SJM" },
    },
    new() {
        Country = new() { Id = 215, Name = "Sweden", TwoLetterIsoCode = "SE", ThreeLetterIsoCode = "SWE" },
        StateProvince = [
            new () {
                Id = 1524,
                Name = "Stockholms län",
                CountryId = 215
            },
            new () {
                Id = 1525,
                Name = "Uppsala län",
                CountryId = 215
            },
            new () {
                Id = 1526,
                Name = "Södermanlands län",
                CountryId = 215
            },
            new () {
                Id = 1527,
                Name = "Östergötlands län",
                CountryId = 215
            },
            new () {
                Id = 1528,
                Name = "Jönköpings län",
                CountryId = 215
            },
            new () {
                Id = 1529,
                Name = "Kronobergs län",
                CountryId = 215
            },
            new () {
                Id = 1530,
                Name = "Kalmar län",
                CountryId = 215
            },
            new () {
                Id = 1531,
                Name = "Gotlands län",
                CountryId = 215
            },
            new () {
                Id = 1532,
                Name = "Blekinge län",
                CountryId = 215
            },
            new () {
                Id = 1533,
                Name = "Skåne län",
                CountryId = 215
            },
            new () {
                Id = 1534,
                Name = "Hallands län",
                CountryId = 215
            },
            new () {
                Id = 1535,
                Name = "Västra Götalands län",
                CountryId = 215
            },
            new () {
                Id = 1536,
                Name = "Värmlands län",
                CountryId = 215
            },
            new () {
                Id = 1537,
                Name = "Örebro län",
                CountryId = 215
            },
            new () {
                Id = 1538,
                Name = "Västmanlands län",
                CountryId = 215
            },
            new () {
                Id = 1539,
                Name = "Dalarnas län",
                CountryId = 215
            },
            new () {
                Id = 1540,
                Name = "Gävleborgs län",
                CountryId = 215
            },
            new () {
                Id = 1541,
                Name = "Jämtlands län",
                CountryId = 215
            },
            new () {
                Id = 1542,
                Name = "Västernorrlands län",
                CountryId = 215
            },
            new () {
                Id = 1543,
                Name = "Västerbottens län",
                CountryId = 215
            },
            new () {
                Id = 1544,
                Name = "Norbottens län",
                CountryId = 215
            },
        ]
    },
    new() {
        Country = new() { Id = 216, Name = "Switzerland", TwoLetterIsoCode = "CH", ThreeLetterIsoCode = "CHE" },
        StateProvince = [
            new () {
                Id = 206,
                Name = "Aargau",
                CountryId = 216
            },
            new () {
                Id = 207,
                Name = "Appenzell Ausserrhoden",
                CountryId = 216
            },
            new () {
                Id = 208,
                Name = "Appenzell Innerrhoden",
                CountryId = 216
            },
            new () {
                Id = 209,
                Name = "Basel-Landschaft",
                CountryId = 216
            },
            new () {
                Id = 210,
                Name = "Basel-Stadt",
                CountryId = 216
            },
            new () {
                Id = 211,
                Name = "Bern",
                CountryId = 216
            },
            new () {
                Id = 212,
                Name = "Fribourg/Freiburg",
                CountryId = 216
            },
            new () {
                Id = 213,
                Name = "Genève",
                CountryId = 216
            },
            new () {
                Id = 214,
                Name = "Glarus",
                CountryId = 216
            },
            new () {
                Id = 215,
                Name = "Graubünden/Grischun",
                CountryId = 216
            },
            new () {
                Id = 216,
                Name = "Jura",
                CountryId = 216
            },
            new () {
                Id = 217,
                Name = "Luzern",
                CountryId = 216
            },
            new () {
                Id = 218,
                Name = "Neuchâtel",
                CountryId = 216
            },
            new () {
                Id = 219,
                Name = "Nidwalden",
                CountryId = 216
            },
            new () {
                Id = 220,
                Name = "Obwalden",
                CountryId = 216
            },
            new () {
                Id = 221,
                Name = "Schaffhausen",
                CountryId = 216
            },
            new () {
                Id = 222,
                Name = "Schwyz",
                CountryId = 216
            },
            new () {
                Id = 223,
                Name = "Solothurn",
                CountryId = 216
            },
            new () {
                Id = 224,
                Name = "St. Gallen",
                CountryId = 216
            },
            new () {
                Id = 225,
                Name = "Ticino",
                CountryId = 216
            },
            new () {
                Id = 226,
                Name = "Thurgau",
                CountryId = 216
            },
            new () {
                Id = 227,
                Name = "Uri",
                CountryId = 216
            },
            new () {
                Id = 228,
                Name = "Vaud",
                CountryId = 216
            },
            new () {
                Id = 229,
                Name = "Valais/Wallis",
                CountryId = 216
            },
            new () {
                Id = 230,
                Name = "Zug",
                CountryId = 216
            },
            new () {
                Id = 231,
                Name = "Zürich",
                CountryId = 216
            },
        ]
    },
    new() {
        Country = new() { Id = 217, Name = "Syrian Arab Republic", TwoLetterIsoCode = "SY", ThreeLetterIsoCode = "SYR" },
    },
    new() {
        Country = new() { Id = 218, Name = "Taiwan, Province of China", TwoLetterIsoCode = "TW", ThreeLetterIsoCode = "TWN" },
    },
    new() {
        Country = new() { Id = 219, Name = "Tajikistan", TwoLetterIsoCode = "TJ", ThreeLetterIsoCode = "TJK" },
    },
    new() {
        Country = new() { Id = 220, Name = "Tanzania, United Republic of", TwoLetterIsoCode = "TZ", ThreeLetterIsoCode = "TZA" },
    },
    new() {
        Country = new() { Id = 221, Name = "Thailand", TwoLetterIsoCode = "TH", ThreeLetterIsoCode = "THA" },
    },
    new() {
        Country = new() { Id = 222, Name = "Timor-Leste", TwoLetterIsoCode = "TL", ThreeLetterIsoCode = "TLS" },
    },
    new() {
        Country = new() { Id = 223, Name = "Togo", TwoLetterIsoCode = "TG", ThreeLetterIsoCode = "TGO" },
    },
    new() {
        Country = new() { Id = 224, Name = "Tokelau", TwoLetterIsoCode = "TK", ThreeLetterIsoCode = "TKL" },
    },
    new() {
        Country = new() { Id = 225, Name = "Tonga", TwoLetterIsoCode = "TO", ThreeLetterIsoCode = "TON" },
    },
    new() {
        Country = new() { Id = 226, Name = "Trinidad and Tobago", TwoLetterIsoCode = "TT", ThreeLetterIsoCode = "TTO" },
    },
    new() {
        Country = new() { Id = 227, Name = "Tunisia", TwoLetterIsoCode = "TN", ThreeLetterIsoCode = "TUN" },
    },
    new() {
        Country = new() { Id = 228, Name = "Turkey", TwoLetterIsoCode = "TR", ThreeLetterIsoCode = "TUR" },
        StateProvince = [
            new () {
                Id = 1565,
                Name = "Adana",
                CountryId = 228
            },
            new () {
                Id = 1566,
                Name = "Adıyaman",
                CountryId = 228
            },
            new () {
                Id = 1567,
                Name = "Afyonkarahisar",
                CountryId = 228
            },
            new () {
                Id = 1568,
                Name = "Ağrı",
                CountryId = 228
            },
            new () {
                Id = 1569,
                Name = "Aksaray",
                CountryId = 228
            },
            new () {
                Id = 1570,
                Name = "Amasya",
                CountryId = 228
            },
            new () {
                Id = 1571,
                Name = "Ankara",
                CountryId = 228
            },
            new () {
                Id = 1572,
                Name = "Antalya",
                CountryId = 228
            },
            new () {
                Id = 1573,
                Name = "Ardahan",
                CountryId = 228
            },
            new () {
                Id = 1574,
                Name = "Artvin",
                CountryId = 228
            },
            new () {
                Id = 1575,
                Name = "Aydın",
                CountryId = 228
            },
            new () {
                Id = 1576,
                Name = "Balıkesir",
                CountryId = 228
            },
            new () {
                Id = 1577,
                Name = "Bartın",
                CountryId = 228
            },
            new () {
                Id = 1578,
                Name = "Batman",
                CountryId = 228
            },
            new () {
                Id = 1579,
                Name = "Bayburt",
                CountryId = 228
            },
            new () {
                Id = 1580,
                Name = "Bilecik",
                CountryId = 228
            },
            new () {
                Id = 1581,
                Name = "Bingöl",
                CountryId = 228
            },
            new () {
                Id = 1582,
                Name = "Bitlis",
                CountryId = 228
            },
            new () {
                Id = 1583,
                Name = "Bolu",
                CountryId = 228
            },
            new () {
                Id = 1584,
                Name = "Burdur",
                CountryId = 228
            },
            new () {
                Id = 1585,
                Name = "Bursa",
                CountryId = 228
            },
            new () {
                Id = 1586,
                Name = "Çanakkale",
                CountryId = 228
            },
            new () {
                Id = 1587,
                Name = "Çankırı",
                CountryId = 228
            },
            new () {
                Id = 1588,
                Name = "Çorum",
                CountryId = 228
            },
            new () {
                Id = 1589,
                Name = "Denizli",
                CountryId = 228
            },
            new () {
                Id = 1590,
                Name = "Diyarbakır",
                CountryId = 228
            },
            new () {
                Id = 1591,
                Name = "Düzce",
                CountryId = 228
            },
            new () {
                Id = 1592,
                Name = "Edirne",
                CountryId = 228
            },
            new () {
                Id = 1593,
                Name = "Elazığ",
                CountryId = 228
            },
            new () {
                Id = 1594,
                Name = "Erzincan",
                CountryId = 228
            },
            new () {
                Id = 1595,
                Name = "Erzurum",
                CountryId = 228
            },
            new () {
                Id = 1596,
                Name = "Eskişehir",
                CountryId = 228
            },
            new () {
                Id = 1597,
                Name = "Gaziantep",
                CountryId = 228
            },
            new () {
                Id = 1598,
                Name = "Giresun",
                CountryId = 228
            },
            new () {
                Id = 1599,
                Name = "Gümüşhane",
                CountryId = 228
            },
            new () {
                Id = 1600,
                Name = "Hakkari",
                CountryId = 228
            },
            new () {
                Id = 1601,
                Name = "Hatay",
                CountryId = 228
            },
            new () {
                Id = 1602,
                Name = "Iğdır",
                CountryId = 228
            },
            new () {
                Id = 1603,
                Name = "Isparta",
                CountryId = 228
            },
            new () {
                Id = 1604,
                Name = "İstanbul",
                CountryId = 228
            },
            new () {
                Id = 1605,
                Name = "İzmir",
                CountryId = 228
            },
            new () {
                Id = 1606,
                Name = "Kahramanmaraş",
                CountryId = 228
            },
            new () {
                Id = 1607,
                Name = "Karabük",
                CountryId = 228
            },
            new () {
                Id = 1608,
                Name = "Karaman",
                CountryId = 228
            },
            new () {
                Id = 1609,
                Name = "Kars",
                CountryId = 228
            },
            new () {
                Id = 1610,
                Name = "Kastamonu",
                CountryId = 228
            },
            new () {
                Id = 1611,
                Name = "Kayseri",
                CountryId = 228
            },
            new () {
                Id = 1612,
                Name = "Kırıkkale",
                CountryId = 228
            },
            new () {
                Id = 1613,
                Name = "Kırklareli",
                CountryId = 228
            },
            new () {
                Id = 1614,
                Name = "Kırşehir",
                CountryId = 228
            },
            new () {
                Id = 1615,
                Name = "Kilis",
                CountryId = 228
            },
            new () {
                Id = 1616,
                Name = "Kocaeli",
                CountryId = 228
            },
            new () {
                Id = 1617,
                Name = "Konya",
                CountryId = 228
            },
            new () {
                Id = 1618,
                Name = "Kütahya",
                CountryId = 228
            },
            new () {
                Id = 1619,
                Name = "Malatya",
                CountryId = 228
            },
            new () {
                Id = 1620,
                Name = "Manisa",
                CountryId = 228
            },
            new () {
                Id = 1621,
                Name = "Mardin",
                CountryId = 228
            },
            new () {
                Id = 1622,
                Name = "Mersin",
                CountryId = 228
            },
            new () {
                Id = 1623,
                Name = "Muğla",
                CountryId = 228
            },
            new () {
                Id = 1624,
                Name = "Muş",
                CountryId = 228
            },
            new () {
                Id = 1625,
                Name = "Nevşehir",
                CountryId = 228
            },
            new () {
                Id = 1626,
                Name = "Niğde",
                CountryId = 228
            },
            new () {
                Id = 1627,
                Name = "Ordu",
                CountryId = 228
            },
            new () {
                Id = 1628,
                Name = "Osmaniye",
                CountryId = 228
            },
            new () {
                Id = 1629,
                Name = "Rize",
                CountryId = 228
            },
            new () {
                Id = 1630,
                Name = "Sakarya",
                CountryId = 228
            },
            new () {
                Id = 1631,
                Name = "Samsun",
                CountryId = 228
            },
            new () {
                Id = 1632,
                Name = "Siirt",
                CountryId = 228
            },
            new () {
                Id = 1633,
                Name = "Sinop",
                CountryId = 228
            },
            new () {
                Id = 1634,
                Name = "Sivas",
                CountryId = 228
            },
            new () {
                Id = 1635,
                Name = "Şanlıurfa",
                CountryId = 228
            },
            new () {
                Id = 1636,
                Name = "Şırnak",
                CountryId = 228
            },
            new () {
                Id = 1637,
                Name = "Tekirdağ",
                CountryId = 228
            },
            new () {
                Id = 1638,
                Name = "Tokat",
                CountryId = 228
            },
            new () {
                Id = 1639,
                Name = "Trabzon",
                CountryId = 228
            },
            new () {
                Id = 1640,
                Name = "Tunceli",
                CountryId = 228
            },
            new () {
                Id = 1641,
                Name = "Uşak",
                CountryId = 228
            },
            new () {
                Id = 1642,
                Name = "Van",
                CountryId = 228
            },
            new () {
                Id = 1643,
                Name = "Yalova",
                CountryId = 228
            },
            new () {
                Id = 1644,
                Name = "Yozgat",
                CountryId = 228
            },
            new () {
                Id = 1645,
                Name = "Zonguldak",
                CountryId = 228
            },
        ]
    },
    new() {
        Country = new() { Id = 229, Name = "Turkmenistan", TwoLetterIsoCode = "TM", ThreeLetterIsoCode = "TKM" },
    },
    new() {
        Country = new() { Id = 230, Name = "Turks and Caicos Islands", TwoLetterIsoCode = "TC", ThreeLetterIsoCode = "TCA" },
    },
    new() {
        Country = new() { Id = 231, Name = "Tuvalu", TwoLetterIsoCode = "TV", ThreeLetterIsoCode = "TUV" },
    },
    new() {
        Country = new() { Id = 232, Name = "Uganda", TwoLetterIsoCode = "UG", ThreeLetterIsoCode = "UGA" },
    },
    new() {
        Country = new() { Id = 233, Name = "Ukraine", TwoLetterIsoCode = "UA", ThreeLetterIsoCode = "UKR" },
        StateProvince = [
            new () {
                Id = 1646,
                Name = "Винницкая область",
                CountryId = 233
            },
            new () {
                Id = 1647,
                Name = "Волынская область",
                CountryId = 233
            },
            new () {
                Id = 1648,
                Name = "Днепропетровская область",
                CountryId = 233
            },
            new () {
                Id = 1649,
                Name = "Донецька область",
                CountryId = 233
            },
            new () {
                Id = 1650,
                Name = "Житомерская область",
                CountryId = 233
            },
            new () {
                Id = 1651,
                Name = "Закарпатская область",
                CountryId = 233
            },
            new () {
                Id = 1652,
                Name = "Запорізька область",
                CountryId = 233
            },
            new () {
                Id = 1653,
                Name = "Ивано-Франковская область",
                CountryId = 233
            },
            new () {
                Id = 1654,
                Name = "Киевская область",
                CountryId = 233
            },
            new () {
                Id = 1655,
                Name = "Кировоградская область",
                CountryId = 233
            },
            new () {
                Id = 1656,
                Name = "Луганская область",
                CountryId = 233
            },
            new () {
                Id = 1657,
                Name = "Львовская область",
                CountryId = 233
            },
            new () {
                Id = 1658,
                Name = "Николаевская область",
                CountryId = 233
            },
            new () {
                Id = 1659,
                Name = "Одесская область",
                CountryId = 233
            },
            new () {
                Id = 1660,
                Name = "Полтавская область",
                CountryId = 233
            },
            new () {
                Id = 1661,
                Name = "Ровненская область",
                CountryId = 233
            },
            new () {
                Id = 1662,
                Name = "Сумская область",
                CountryId = 233
            },
            new () {
                Id = 1663,
                Name = "Тернопільська область",
                CountryId = 233
            },
            new () {
                Id = 1664,
                Name = "Харковская область",
                CountryId = 233
            },
            new () {
                Id = 1665,
                Name = "Херсонская область",
                CountryId = 233
            },
            new () {
                Id = 1666,
                Name = "Хмельницька область",
                CountryId = 233
            },
            new () {
                Id = 1667,
                Name = "Черкасская область",
                CountryId = 233
            },
            new () {
                Id = 1668,
                Name = "Черниговская область",
                CountryId = 233
            },
            new () {
                Id = 1669,
                Name = "Черновицкая область",
                CountryId = 233
            },
        ]
    },
    new() {
        Country = new() { Id = 234, Name = "United Arab Emirates", TwoLetterIsoCode = "AE", ThreeLetterIsoCode = "ARE" },
    },
    new() {
        Country = new() { Id = 235, Name = "United Kingdom of Great Britain and Northern Ireland", TwoLetterIsoCode = "GB", ThreeLetterIsoCode = "GBR" },
        StateProvince = [
            new () {
                Id = 581,
                Name = "Aberdeenshire",
                CountryId = 235
            },
            new () {
                Id = 582,
                Name = "Anglesey/Sir Fon",
                CountryId = 235
            },
            new () {
                Id = 583,
                Name = "Angus",
                CountryId = 235
            },
            new () {
                Id = 584,
                Name = "Argyll and Bute",
                CountryId = 235
            },
            new () {
                Id = 585,
                Name = "Ayrshire",
                CountryId = 235
            },
            new () {
                Id = 586,
                Name = "Berkshire",
                CountryId = 235
            },
            new () {
                Id = 587,
                Name = "Blaenau Gwent",
                CountryId = 235
            },
            new () {
                Id = 588,
                Name = "Bridgend",
                CountryId = 235
            },
            new () {
                Id = 589,
                Name = "Bristol",
                CountryId = 235
            },
            new () {
                Id = 590,
                Name = "Buckinghamshire",
                CountryId = 235
            },
            new () {
                Id = 591,
                Name = "Caerphilly",
                CountryId = 235
            },
            new () {
                Id = 592,
                Name = "Cambridgeshire",
                CountryId = 235
            },
            new () {
                Id = 593,
                Name = "Cardiff",
                CountryId = 235
            },
            new () {
                Id = 594,
                Name = "Carmarthenshire",
                CountryId = 235
            },
            new () {
                Id = 595,
                Name = "Ceredigion",
                CountryId = 235
            },
            new () {
                Id = 596,
                Name = "Cheshire",
                CountryId = 235
            },
            new () {
                Id = 597,
                Name = "Clackmannanshire",
                CountryId = 235
            },
            new () {
                Id = 598,
                Name = "Conwy",
                CountryId = 235
            },
            new () {
                Id = 599,
                Name = "Cornwall",
                CountryId = 235
            },
            new () {
                Id = 600,
                Name = "County Antrim",
                CountryId = 235
            },
            new () {
                Id = 601,
                Name = "County Armagh",
                CountryId = 235
            },
            new () {
                Id = 602,
                Name = "County Down",
                CountryId = 235
            },
            new () {
                Id = 603,
                Name = "County Fermanagh",
                CountryId = 235
            },
            new () {
                Id = 604,
                Name = "County Londonderry",
                CountryId = 235
            },
            new () {
                Id = 605,
                Name = "County Tyrone",
                CountryId = 235
            },
            new () {
                Id = 606,
                Name = "Cumbria",
                CountryId = 235
            },
            new () {
                Id = 607,
                Name = "Denbighshire",
                CountryId = 235
            },
            new () {
                Id = 608,
                Name = "Derbyshire",
                CountryId = 235
            },
            new () {
                Id = 609,
                Name = "Devon",
                CountryId = 235
            },
            new () {
                Id = 610,
                Name = "Dorset",
                CountryId = 235
            },
            new () {
                Id = 611,
                Name = "Dumfries and Galloway",
                CountryId = 235
            },
            new () {
                Id = 612,
                Name = "Dunbartonshire",
                CountryId = 235
            },
            new () {
                Id = 613,
                Name = "Dundee",
                CountryId = 235
            },
            new () {
                Id = 614,
                Name = "Durham",
                CountryId = 235
            },
            new () {
                Id = 615,
                Name = "East Lothian",
                CountryId = 235
            },
            new () {
                Id = 616,
                Name = "East Riding of Yorkshire",
                CountryId = 235
            },
            new () {
                Id = 617,
                Name = "East Sussex",
                CountryId = 235
            },
            new () {
                Id = 618,
                Name = "Edinburgh",
                CountryId = 235
            },
            new () {
                Id = 619,
                Name = "Essex",
                CountryId = 235
            },
            new () {
                Id = 620,
                Name = "Falkirk",
                CountryId = 235
            },
            new () {
                Id = 621,
                Name = "Fife",
                CountryId = 235
            },
            new () {
                Id = 622,
                Name = "Flintshire",
                CountryId = 235
            },
            new () {
                Id = 623,
                Name = "Glamorgan",
                CountryId = 235
            },
            new () {
                Id = 624,
                Name = "Glasgow",
                CountryId = 235
            },
            new () {
                Id = 625,
                Name = "Gloucestershire",
                CountryId = 235
            },
            new () {
                Id = 626,
                Name = "Greater Manchester",
                CountryId = 235
            },
            new () {
                Id = 627,
                Name = "Gwynedd",
                CountryId = 235
            },
            new () {
                Id = 628,
                Name = "Hampshire",
                CountryId = 235
            },
            new () {
                Id = 629,
                Name = "Hereford and Worcester",
                CountryId = 235
            },
            new () {
                Id = 630,
                Name = "Hertfordshire",
                CountryId = 235
            },
            new () {
                Id = 631,
                Name = "Highland",
                CountryId = 235
            },
            new () {
                Id = 632,
                Name = "Inverclyde",
                CountryId = 235
            },
            new () {
                Id = 633,
                Name = "Isle of Man",
                CountryId = 235
            },
            new () {
                Id = 634,
                Name = "Isle of Wight",
                CountryId = 235
            },
            new () {
                Id = 635,
                Name = "Kent",
                CountryId = 235
            },
            new () {
                Id = 636,
                Name = "Lanarkshire",
                CountryId = 235
            },
            new () {
                Id = 637,
                Name = "Lancashire",
                CountryId = 235
            },
            new () {
                Id = 638,
                Name = "Leicestershire",
                CountryId = 235
            },
            new () {
                Id = 639,
                Name = "Lincolnshire",
                CountryId = 235
            },
            new () {
                Id = 640,
                Name = "London",
                CountryId = 235
            },
            new () {
                Id = 641,
                Name = "Merseyside",
                CountryId = 235
            },
            new () {
                Id = 642,
                Name = "Merthyr Tydfil",
                CountryId = 235
            },
            new () {
                Id = 643,
                Name = "Middlesex",
                CountryId = 235
            },
            new () {
                Id = 644,
                Name = "Midlothian",
                CountryId = 235
            },
            new () {
                Id = 645,
                Name = "Monmouthshire",
                CountryId = 235
            },
            new () {
                Id = 646,
                Name = "Moray",
                CountryId = 235
            },
            new () {
                Id = 647,
                Name = "Neath Port Talbot",
                CountryId = 235
            },
            new () {
                Id = 648,
                Name = "Newport",
                CountryId = 235
            },
            new () {
                Id = 649,
                Name = "Norfolk",
                CountryId = 235
            },
            new () {
                Id = 650,
                Name = "North Yorkshire",
                CountryId = 235
            },
            new () {
                Id = 651,
                Name = "Northamptonshire",
                CountryId = 235
            },
            new () {
                Id = 652,
                Name = "Northumberland",
                CountryId = 235
            },
            new () {
                Id = 653,
                Name = "Nottinghamshire",
                CountryId = 235
            },
            new () {
                Id = 654,
                Name = "Orkney",
                CountryId = 235
            },
            new () {
                Id = 655,
                Name = "Oxfordshire",
                CountryId = 235
            },
            new () {
                Id = 656,
                Name = "Pembrokeshire",
                CountryId = 235
            },
            new () {
                Id = 657,
                Name = "Perth and Kinross",
                CountryId = 235
            },
            new () {
                Id = 658,
                Name = "Powys",
                CountryId = 235
            },
            new () {
                Id = 659,
                Name = "Renfrewshire",
                CountryId = 235
            },
            new () {
                Id = 660,
                Name = "Rhondda Cynon Taff",
                CountryId = 235
            },
            new () {
                Id = 661,
                Name = "Rutland",
                CountryId = 235
            },
            new () {
                Id = 662,
                Name = "Scottish Borders",
                CountryId = 235
            },
            new () {
                Id = 663,
                Name = "Shetland Isles",
                CountryId = 235
            },
            new () {
                Id = 664,
                Name = "Shropshire",
                CountryId = 235
            },
            new () {
                Id = 665,
                Name = "Somerset",
                CountryId = 235
            },
            new () {
                Id = 666,
                Name = "South Yorkshire",
                CountryId = 235
            },
            new () {
                Id = 667,
                Name = "Staffordshire",
                CountryId = 235
            },
            new () {
                Id = 668,
                Name = "Stirlingshire",
                CountryId = 235
            },
            new () {
                Id = 669,
                Name = "Suffolk",
                CountryId = 235
            },
            new () {
                Id = 670,
                Name = "Surrey",
                CountryId = 235
            },
            new () {
                Id = 671,
                Name = "Swansea",
                CountryId = 235
            },
            new () {
                Id = 672,
                Name = "Torfaen",
                CountryId = 235
            },
            new () {
                Id = 673,
                Name = "Tyne and Wear",
                CountryId = 235
            },
            new () {
                Id = 674,
                Name = "Warwickshire",
                CountryId = 235
            },
            new () {
                Id = 675,
                Name = "West Lothian",
                CountryId = 235
            },
            new () {
                Id = 676,
                Name = "West Midlands",
                CountryId = 235
            },
            new () {
                Id = 677,
                Name = "West Sussex",
                CountryId = 235
            },
            new () {
                Id = 678,
                Name = "West Yorkshire",
                CountryId = 235
            },
            new () {
                Id = 679,
                Name = "Western Isles",
                CountryId = 235
            },
            new () {
                Id = 680,
                Name = "Wiltshire",
                CountryId = 235
            },
            new () {
                Id = 681,
                Name = "Wrexham",
                CountryId = 235
            },
        ]
    },
    new() {
        Country = new() { Id = 236, Name = "United States Minor Outlying Islands", TwoLetterIsoCode = "UM", ThreeLetterIsoCode = "UMI" },
    },
    new() {
        Country = new() { Id = 237, Name = "United States of America", TwoLetterIsoCode = "US", ThreeLetterIsoCode = "USA" },
        StateProvince = [
            new () {
                Id = 1670,
                Name = "AA (Armed Forces Americas)",
                CountryId = 237
            },
            new () {
                Id = 1671,
                Name = "AE (Armed Forces Europe)",
                CountryId = 237
            },
            new () {
                Id = 1672,
                Name = "Alabama",
                CountryId = 237
            },
            new () {
                Id = 1673,
                Name = "Alaska",
                CountryId = 237
            },
            new () {
                Id = 1674,
                Name = "American Samoa",
                CountryId = 237
            },
            new () {
                Id = 1675,
                Name = "AP (Armed Forces Pacific)",
                CountryId = 237
            },
            new () {
                Id = 1676,
                Name = "Arizona",
                CountryId = 237
            },
            new () {
                Id = 1677,
                Name = "Arkansas",
                CountryId = 237
            },
            new () {
                Id = 1678,
                Name = "California",
                CountryId = 237
            },
            new () {
                Id = 1679,
                Name = "Colorado",
                CountryId = 237
            },
            new () {
                Id = 1680,
                Name = "Connecticut",
                CountryId = 237
            },
            new () {
                Id = 1681,
                Name = "Delaware",
                CountryId = 237
            },
            new () {
                Id = 1682,
                Name = "District of Columbia",
                CountryId = 237
            },
            new () {
                Id = 1683,
                Name = "Federated States of Micronesia",
                CountryId = 237
            },
            new () {
                Id = 1684,
                Name = "Florida",
                CountryId = 237
            },
            new () {
                Id = 1685,
                Name = "Georgia",
                CountryId = 237
            },
            new () {
                Id = 1686,
                Name = "Guam",
                CountryId = 237
            },
            new () {
                Id = 1687,
                Name = "Hawaii",
                CountryId = 237
            },
            new () {
                Id = 1688,
                Name = "Idaho",
                CountryId = 237
            },
            new () {
                Id = 1689,
                Name = "Illinois",
                CountryId = 237
            },
            new () {
                Id = 1690,
                Name = "Indiana",
                CountryId = 237
            },
            new () {
                Id = 1691,
                Name = "Iowa",
                CountryId = 237
            },
            new () {
                Id = 1692,
                Name = "Kansas",
                CountryId = 237
            },
            new () {
                Id = 1693,
                Name = "Kentucky",
                CountryId = 237
            },
            new () {
                Id = 1694,
                Name = "Louisiana",
                CountryId = 237
            },
            new () {
                Id = 1695,
                Name = "Maine",
                CountryId = 237
            },
            new () {
                Id = 1696,
                Name = "Marshall Islands",
                CountryId = 237
            },
            new () {
                Id = 1697,
                Name = "Maryland",
                CountryId = 237
            },
            new () {
                Id = 1698,
                Name = "Massachusetts",
                CountryId = 237
            },
            new () {
                Id = 1699,
                Name = "Michigan",
                CountryId = 237
            },
            new () {
                Id = 1700,
                Name = "Minnesota",
                CountryId = 237
            },
            new () {
                Id = 1701,
                Name = "Mississippi",
                CountryId = 237
            },
            new () {
                Id = 1702,
                Name = "Missouri",
                CountryId = 237
            },
            new () {
                Id = 1703,
                Name = "Montana",
                CountryId = 237
            },
            new () {
                Id = 1704,
                Name = "Nebraska",
                CountryId = 237
            },
            new () {
                Id = 1705,
                Name = "Nevada",
                CountryId = 237
            },
            new () {
                Id = 1706,
                Name = "New Hampshire",
                CountryId = 237
            },
            new () {
                Id = 1707,
                Name = "New Jersey",
                CountryId = 237
            },
            new () {
                Id = 1708,
                Name = "New Mexico",
                CountryId = 237
            },
            new () {
                Id = 1709,
                Name = "New York",
                CountryId = 237
            },
            new () {
                Id = 1710,
                Name = "North Carolina",
                CountryId = 237
            },
            new () {
                Id = 1711,
                Name = "North Dakota",
                CountryId = 237
            },
            new () {
                Id = 1712,
                Name = "Northern Mariana Islands",
                CountryId = 237
            },
            new () {
                Id = 1713,
                Name = "Ohio",
                CountryId = 237
            },
            new () {
                Id = 1714,
                Name = "Oklahoma",
                CountryId = 237
            },
            new () {
                Id = 1715,
                Name = "Oregon",
                CountryId = 237
            },
            new () {
                Id = 1716,
                Name = "Palau",
                CountryId = 237
            },
            new () {
                Id = 1717,
                Name = "Pennsylvania",
                CountryId = 237
            },
            new () {
                Id = 1718,
                Name = "Puerto Rico",
                CountryId = 237
            },
            new () {
                Id = 1719,
                Name = "Rhode Island",
                CountryId = 237
            },
            new () {
                Id = 1720,
                Name = "South Carolina",
                CountryId = 237
            },
            new () {
                Id = 1721,
                Name = "South Dakota",
                CountryId = 237
            },
            new () {
                Id = 1722,
                Name = "Tennessee",
                CountryId = 237
            },
            new () {
                Id = 1723,
                Name = "Texas",
                CountryId = 237
            },
            new () {
                Id = 1724,
                Name = "Utah",
                CountryId = 237
            },
            new () {
                Id = 1725,
                Name = "Vermont",
                CountryId = 237
            },
            new () {
                Id = 1726,
                Name = "Virgin Islands",
                CountryId = 237
            },
            new () {
                Id = 1727,
                Name = "Virginia",
                CountryId = 237
            },
            new () {
                Id = 1728,
                Name = "Washington",
                CountryId = 237
            },
            new () {
                Id = 1729,
                Name = "West Virginia",
                CountryId = 237
            },
            new () {
                Id = 1730,
                Name = "Wisconsin",
                CountryId = 237
            },
            new () {
                Id = 1731,
                Name = "Wyoming",
                CountryId = 237
            },
        ]
    },
    new() {
        Country = new() { Id = 238, Name = "Uruguay", TwoLetterIsoCode = "UY", ThreeLetterIsoCode = "URY" },
    },
    new() {
        Country = new() { Id = 239, Name = "Uzbekistan", TwoLetterIsoCode = "UZ", ThreeLetterIsoCode = "UZB" },
    },
    new() {
        Country = new() { Id = 240, Name = "Vanuatu", TwoLetterIsoCode = "VU", ThreeLetterIsoCode = "VUT" },
    },
    new() {
        Country = new() { Id = 241, Name = "Venezuela (Bolivarian Republic of)", TwoLetterIsoCode = "VE", ThreeLetterIsoCode = "VEN" },
        StateProvince = [
            new () {
                Id = 1732,
                Name = "Amazonas",
                CountryId = 241
            },
            new () {
                Id = 1733,
                Name = "Anzoategui",
                CountryId = 241
            },
            new () {
                Id = 1734,
                Name = "Apure",
                CountryId = 241
            },
            new () {
                Id = 1735,
                Name = "Aragua",
                CountryId = 241
            },
            new () {
                Id = 1736,
                Name = "Barinas",
                CountryId = 241
            },
            new () {
                Id = 1737,
                Name = "Bolívar",
                CountryId = 241
            },
            new () {
                Id = 1738,
                Name = "Carabobo",
                CountryId = 241
            },
            new () {
                Id = 1739,
                Name = "Cojedes",
                CountryId = 241
            },
            new () {
                Id = 1740,
                Name = "Delta Amacuro",
                CountryId = 241
            },
            new () {
                Id = 1741,
                Name = "Distrito Capital",
                CountryId = 241
            },
            new () {
                Id = 1742,
                Name = "Falcón",
                CountryId = 241
            },
            new () {
                Id = 1743,
                Name = "Guárico",
                CountryId = 241
            },
            new () {
                Id = 1744,
                Name = "Lara",
                CountryId = 241
            },
            new () {
                Id = 1745,
                Name = "Mérida",
                CountryId = 241
            },
            new () {
                Id = 1746,
                Name = "Miranda",
                CountryId = 241
            },
            new () {
                Id = 1747,
                Name = "Monagas",
                CountryId = 241
            },
            new () {
                Id = 1748,
                Name = "Nueva Esparta",
                CountryId = 241
            },
            new () {
                Id = 1749,
                Name = "Portuguesa",
                CountryId = 241
            },
            new () {
                Id = 1750,
                Name = "Sucre",
                CountryId = 241
            },
            new () {
                Id = 1751,
                Name = "Táchira",
                CountryId = 241
            },
            new () {
                Id = 1752,
                Name = "Trujillo",
                CountryId = 241
            },
            new () {
                Id = 1753,
                Name = "Vargas",
                CountryId = 241
            },
            new () {
                Id = 1754,
                Name = "Yaracuy",
                CountryId = 241
            },
            new () {
                Id = 1755,
                Name = "Zulia",
                CountryId = 241
            },
        ]
    },
    new() {
        Country = new() { Id = 242, Name = "Viet Nam", TwoLetterIsoCode = "VN", ThreeLetterIsoCode = "VNM" },
        StateProvince = [
            new () {
                Id = 1756,
                Name = "Hà Nội",
                CountryId = 242
            },
            new () {
                Id = 1757,
                Name = "Hồ Chí Minh",
                CountryId = 242
            },
            new () {
                Id = 1758,
                Name = "Đà Nẵng",
                CountryId = 242
            },
            new () {
                Id = 1759,
                Name = "Hải Phòng",
                CountryId = 242
            },
            new () {
                Id = 1760,
                Name = "Cần Thơ",
                CountryId = 242
            },
            new () {
                Id = 1761,
                Name = "Hà Giang",
                CountryId = 242
            },
            new () {
                Id = 1762,
                Name = "Cao Bằng",
                CountryId = 242
            },
            new () {
                Id = 1763,
                Name = "Bắc Kạn",
                CountryId = 242
            },
            new () {
                Id = 1764,
                Name = "Tuyên Quang",
                CountryId = 242
            },
            new () {
                Id = 1765,
                Name = "Lào Cai",
                CountryId = 242
            },
            new () {
                Id = 1766,
                Name = "Điện Biên",
                CountryId = 242
            },
            new () {
                Id = 1767,
                Name = "Lai Châu",
                CountryId = 242
            },
            new () {
                Id = 1768,
                Name = "Sơn La",
                CountryId = 242
            },
            new () {
                Id = 1769,
                Name = "Yên Bái",
                CountryId = 242
            },
            new () {
                Id = 1770,
                Name = "Hòa Bình",
                CountryId = 242
            },
            new () {
                Id = 1771,
                Name = "Thái Nguyên",
                CountryId = 242
            },
            new () {
                Id = 1772,
                Name = "Lạng Sơn",
                CountryId = 242
            },
            new () {
                Id = 1773,
                Name = "Quảng Ninh",
                CountryId = 242
            },
            new () {
                Id = 1774,
                Name = "Bắc Giang",
                CountryId = 242
            },
            new () {
                Id = 1775,
                Name = "Phú Thọ",
                CountryId = 242
            },
            new () {
                Id = 1776,
                Name = "Vĩnh Phúc",
                CountryId = 242
            },
            new () {
                Id = 1777,
                Name = "Bắc Ninh",
                CountryId = 242
            },
            new () {
                Id = 1778,
                Name = "Hải Dương",
                CountryId = 242
            },
            new () {
                Id = 1779,
                Name = "Hưng Yên",
                CountryId = 242
            },
            new () {
                Id = 1780,
                Name = "Thái Bình",
                CountryId = 242
            },
            new () {
                Id = 1781,
                Name = "Hà Nam",
                CountryId = 242
            },
            new () {
                Id = 1782,
                Name = "Nam Định",
                CountryId = 242
            },
            new () {
                Id = 1783,
                Name = "Ninh Bình",
                CountryId = 242
            },
            new () {
                Id = 1784,
                Name = "Thanh Hóa",
                CountryId = 242
            },
            new () {
                Id = 1785,
                Name = "Nghệ An",
                CountryId = 242
            },
            new () {
                Id = 1786,
                Name = "Hà Tĩnh",
                CountryId = 242
            },
            new () {
                Id = 1787,
                Name = "Quảng Bình",
                CountryId = 242
            },
            new () {
                Id = 1788,
                Name = "Quảng Trị",
                CountryId = 242
            },
            new () {
                Id = 1789,
                Name = "Thừa Thiên Huế",
                CountryId = 242
            },
            new () {
                Id = 1790,
                Name = "Quảng Nam",
                CountryId = 242
            },
            new () {
                Id = 1791,
                Name = "Quảng Ngãi",
                CountryId = 242
            },
            new () {
                Id = 1792,
                Name = "Bình Định",
                CountryId = 242
            },
            new () {
                Id = 1793,
                Name = "Phú Yên",
                CountryId = 242
            },
            new () {
                Id = 1794,
                Name = "Khánh Hòa",
                CountryId = 242
            },
            new () {
                Id = 1795,
                Name = "Ninh Thuận",
                CountryId = 242
            },
            new () {
                Id = 1796,
                Name = "Bình Thuận",
                CountryId = 242
            },
            new () {
                Id = 1797,
                Name = "Kon Tum",
                CountryId = 242
            },
            new () {
                Id = 1798,
                Name = "Gia Lai",
                CountryId = 242
            },
            new () {
                Id = 1799,
                Name = "Đắk Lắk",
                CountryId = 242
            },
            new () {
                Id = 1800,
                Name = "Đắk Nông",
                CountryId = 242
            },
            new () {
                Id = 1801,
                Name = "Lâm Đồng",
                CountryId = 242
            },
            new () {
                Id = 1802,
                Name = "Bình Phước",
                CountryId = 242
            },
            new () {
                Id = 1803,
                Name = "Tây Ninh",
                CountryId = 242
            },
            new () {
                Id = 1804,
                Name = "Bình Dương",
                CountryId = 242
            },
            new () {
                Id = 1805,
                Name = "Đồng Nai",
                CountryId = 242
            },
            new () {
                Id = 1806,
                Name = "Bà Rịa - Vũng Tàu",
                CountryId = 242
            },
            new () {
                Id = 1807,
                Name = "Long An",
                CountryId = 242
            },
            new () {
                Id = 1808,
                Name = "Tiền Giang",
                CountryId = 242
            },
            new () {
                Id = 1809,
                Name = "Bến Tre",
                CountryId = 242
            },
            new () {
                Id = 1810,
                Name = "Trà Vinh",
                CountryId = 242
            },
            new () {
                Id = 1811,
                Name = "Vĩnh Long",
                CountryId = 242
            },
            new () {
                Id = 1812,
                Name = "Đồng Tháp",
                CountryId = 242
            },
            new () {
                Id = 1813,
                Name = "An Giang",
                CountryId = 242
            },
            new () {
                Id = 1814,
                Name = "Kiên Giang",
                CountryId = 242
            },
            new () {
                Id = 1815,
                Name = "Hậu Giang",
                CountryId = 242
            },
            new () {
                Id = 1816,
                Name = "Sóc Trăng",
                CountryId = 242
            },
            new () {
                Id = 1817,
                Name = "Bạc Liêu",
                CountryId = 242
            },
            new () {
                Id = 1818,
                Name = "Cà Mau",
                CountryId = 242
            },
        ]
    },
    new() {
        Country = new() { Id = 243, Name = "Virgin Islands (British)", TwoLetterIsoCode = "VG", ThreeLetterIsoCode = "VGB" },
    },
    new() {
        Country = new() { Id = 244, Name = "Virgin Islands (U.S.)", TwoLetterIsoCode = "VI", ThreeLetterIsoCode = "VIR" },
    },
    new() {
        Country = new() { Id = 245, Name = "Wallis and Futuna", TwoLetterIsoCode = "WF", ThreeLetterIsoCode = "WLF" },
    },
    new() {
        Country = new() { Id = 246, Name = "Western Sahara", TwoLetterIsoCode = "EH", ThreeLetterIsoCode = "ESH" },
    },
    new() {
        Country = new() { Id = 247, Name = "Yemen", TwoLetterIsoCode = "YE", ThreeLetterIsoCode = "YEM" },
    },
    new() {
        Country = new() { Id = 248, Name = "Zambia", TwoLetterIsoCode = "ZM", ThreeLetterIsoCode = "ZMB" },
    },
    new() {
        Country = new() { Id = 249, Name = "Zimbabwe", TwoLetterIsoCode = "ZW", ThreeLetterIsoCode = "ZWE" },
        StateProvince = [
            new () {
                Id = 1827,
                Name = "Bulawayo",
                CountryId = 249
            },
            new () {
                Id = 1828,
                Name = "Harare",
                CountryId = 249
            },
            new () {
                Id = 1829,
                Name = "Manicaland",
                CountryId = 249
            },
            new () {
                Id = 1830,
                Name = "Mashonaland Central",
                CountryId = 249
            },
            new () {
                Id = 1831,
                Name = "Mashonaland East",
                CountryId = 249
            },
            new () {
                Id = 1832,
                Name = "Mashonaland West",
                CountryId = 249
            },
            new () {
                Id = 1833,
                Name = "Masvingo",
                CountryId = 249
            },
            new () {
                Id = 1834,
                Name = "Matabeleland North",
                CountryId = 249
            },
            new () {
                Id = 1835,
                Name = "Matabeleland South",
                CountryId = 249
            },
            new () {
                Id = 1836,
                Name = "Midlands",
                CountryId = 249
            },
        ]
    },
];
}