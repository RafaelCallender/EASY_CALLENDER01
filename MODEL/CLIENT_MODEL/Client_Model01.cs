
namespace EASYPROJECT01.EASY_CALLENDER01.MODEL.CLIENT_MODEL
{
        public class Client_Model01
        {

                private static string[] client_name =
                        {
"Liam","Emma","Noah","Olivia","Oliver","Ava","Elijah","Isabella","William","Sophia",
    "James","Charlotte","Benjamin","Amelia","Lucas","Mia","Henry","Harper","Alexander","Evelyn",
    "Mason","Abigail","Michael","Emily","Ethan","Ella","Daniel","Avery","Jacob","Sofia",
    "Logan","Camila","Jackson","Aria","Levi","Scarlett","Sebastian","Victoria","Mateo","Madison",
    "Jack","Luna","Owen","Grace","Theodore","Chloe","Aiden","Penelope","Samuel","Layla",
    "Joseph","Riley","John","Zoey","David","Nora","Wyatt","Lily","Matthew","Eleanor",
    "Luke","Hannah","Asher","Lillian","Carter","Addison","Julian","Aubrey","Grayson","Ellie",
    "Leo","Stella","Jayden","Natalie","Gabriel","Zoe","Isaac","Leah","Lincoln","Hazel",
    "Anthony","Violet","Hudson","Aurora","Dylan","Savannah","Ezra","Audrey","Thomas","Brooklyn",
    "Charles","Bella","Josiah","Claire","Christopher","Skylar","Caleb","Lucy","Jaxon","Paisley",
    "Christian","Everly","Hunter","Anna"
        };
                private static string[] client_emailaddress =
                        {
"Liam.Smith@gmail.com","Emma.Johnson@yahoo.com","Noah.Williams@hotmail.com","Olivia.Brown@outlook.com",
    "Oliver.Jones@gmail.com","Ava.Garcia@yahoo.com","Elijah.Miller@hotmail.com","Isabella.Davis@outlook.com",
    "William.Rodriguez@gmail.com","Sophia.Martinez@yahoo.com","James.Hernandez@hotmail.com","Charlotte.Lopez@outlook.com",
    "Benjamin.Gonzales@gmail.com","Amelia.Wilson@yahoo.com","Lucas.Anderson@hotmail.com","Mia.Thomas@outlook.com",
    "Henry.Taylor@gmail.com","Harper.Moore@yahoo.com","Alexander.Jackson@hotmail.com","Evelyn.Martin@outlook.com",
    "Mason.Lee@gmail.com","Abigail.Perez@yahoo.com","Michael.Thompson@hotmail.com","Emily.White@outlook.com",
    "Ethan.Harris@gmail.com","Ella.Sanchez@yahoo.com","Daniel.Clark@hotmail.com","Avery.Ramirez@outlook.com",
    "Jacob.Lewis@gmail.com","Sofia.Robinson@yahoo.com","Logan.Walker@hotmail.com","Camila.Young@outlook.com",
    "Jackson.Allen@gmail.com","Aria.King@yahoo.com","Levi.Wright@hotmail.com","Scarlett.Scott@outlook.com",
    "Sebastian.Torres@gmail.com","Victoria.Nguyen@yahoo.com","Mateo.Hill@hotmail.com","Madison.Flores@outlook.com",
    "Jack.Green@gmail.com","Luna.Adams@yahoo.com","Owen.Nelson@hotmail.com","Grace.Baker@outlook.com",
    "Theodore.Hall@gmail.com","Chloe.Rivera@yahoo.com","Aiden.Campbell@hotmail.com","Penelope.Mitchell@outlook.com",
    "Samuel.Carter@gmail.com","Layla.Roberts@yahoo.com","Joseph.Gomez@hotmail.com","Riley.Phillips@outlook.com",
    "John.Evans@gmail.com","Zoey.Turner@yahoo.com","David.Diaz@hotmail.com","Nora.Parker@outlook.com",
    "Wyatt.Cruz@gmail.com","Lily.Edwards@yahoo.com","Matthew.Collins@hotmail.com","Eleanor.Reyes@outlook.com",
    "Luke.Stewart@gmail.com","Hannah.Morris@yahoo.com","Asher.Morales@hotmail.com","Lillian.Murphy@outlook.com",
    "Carter.Cook@gmail.com","Addison.Rogers@yahoo.com","Julian.Gutierrez@hotmail.com","Aubrey.Ortiz@outlook.com",
    "Grayson.Morgan@gmail.com","Ellie.Cooper@yahoo.com","Leo.Peterson@hotmail.com","Stella.Bailey@outlook.com",
    "Jayden.Reed@gmail.com","Natalie.Kelly@yahoo.com","Gabriel.Howard@hotmail.com","Zoe.Ramos@outlook.com",
    "Isaac.Kim@gmail.com","Leah.Cox@yahoo.com","Lincoln.Ward@hotmail.com","Hazel.Richardson@outlook.com",
    "Anthony.Watson@gmail.com","Violet.Brooks@yahoo.com","Hudson.Chavez@hotmail.com","Aurora.Wood@outlook.com",
    "Dylan.James@gmail.com","Savannah.Bennett@yahoo.com","Ezra.Gray@hotmail.com","Audrey.Mendoza@outlook.com",
    "Thomas.Ruiz@gmail.com","Brooklyn.Hughes@yahoo.com","Charles.Price@hotmail.com","Bella.Alvarez@outlook.com",
    "Josiah.Castillo@gmail.com","Claire.Sanders@yahoo.com","Christopher.Patel@hotmail.com","Skylar.Myers@outlook.com",
    "Caleb.Long@gmail.com","Lucy.Ross@yahoo.com","Jaxon.Foster@hotmail.com","Paisley.Jimenez@outlook.com"
        };
                private static string[] client_phonenumber =
                        {
"(212) 555-0173","(305) 555-0142","(415) 555-0198","(619) 555-0183","(713) 555-0129",
    "(312) 555-0167","(702) 555-0118","(404) 555-0135","(503) 555-0179","(602) 555-0156",
    "(214) 555-0131","(310) 555-0191","(516) 555-0187","(407) 555-0149","(786) 555-0124",
    "(617) 555-0163","(503) 555-0151","(954) 555-0175","(916) 555-0139","(801) 555-0181",
    "(305) 555-0153","(312) 555-0197","(713) 555-0171","(602) 555-0161","(425) 555-0147",
    "(404) 555-0185","(907) 555-0115","(719) 555-0165","(970) 555-0133","(928) 555-0193",
    "(317) 555-0148","(617) 555-0182","(832) 555-0195","(404) 555-0127","(702) 555-0159",
    "(212) 555-0141","(407) 555-0177","(214) 555-0158","(803) 555-0132","(303) 555-0168",
    "(801) 555-0178","(678) 555-0126","(516) 555-0194","(312) 555-0119","(713) 555-0179",
    "(415) 555-0138","(305) 555-0172","(602) 555-0146","(303) 555-0190","(818) 555-0154",
    "(321) 555-0176","(215) 555-0188","(503) 555-0145","(954) 555-0169","(512) 555-0117",
    "(619) 555-0192","(404) 555-0162","(480) 555-0180","(713) 555-0143","(212) 555-0155",
    "(702) 555-0164","(617) 555-0196","(305) 555-0121","(818) 555-0113","(214) 555-0170",
    "(516) 555-0144","(425) 555-0134","(602) 555-0189","(312) 555-0152","(803) 555-0116",
    "(954) 555-0174","(801) 555-0188","(907) 555-0130","(615) 555-0174","(210) 555-0199",
    "(409) 555-0160","(702) 555-0122","(305) 555-0114","(617) 555-0186","(323) 555-0149",
    "(408) 555-0174","(801) 555-0166","(312) 555-0199","(702) 555-0150","(214) 555-0123",
    "(516) 555-0184","(404) 555-0170","(305) 555-0188","(212) 555-0136","(714) 555-0142"
        };
                private static string[] client_api_key =
                        {

    "api_key_1", "api_key_2", "api_key_3", "api_key_4", "api_key_5", "api_key_6", "api_key_7", "api_key_8", "api_key_9", "api_key_10", "api_key_11", "api_key_12", "api_key_13", "api_key_14", "api_key_15", "api_key_16", "api_key_17", "api_key_18", "api_key_19", "api_key_20", "api_key_21", "api_key_22", "api_key_23", "api_key_24", "api_key_25", "api_key_26", "api_key_27", "api_key_28", "api_key_29", "api_key_30", "api_key_31", "api_key_32", "api_key_33", "api_key_34", "api_key_35", "api_key_36", "api_key_37", "api_key_38", "api_key_39", "api_key_40", "api_key_41", "api_key_42", "api_key_43", "api_key_44", "api_key_45", "api_key_46", "api_key_47", "api_key_48", "api_key_49", "api_key_50", "api_key_51", "api_key_52", "api_key_53", "api_key_54", "api_key_55", "api_key_56", "api_key_57", "api_key_58", "api_key_59", "api_key_60", "api_key_61", "api_key_62", "api_key_63", "api_key_64", "api_key_65", "api_key_66", "api_key_67", "api_key_68", "api_key_69", "api_key_70", "api_key_71", "api_key_72", "api_key_73", "api_key_74", "api_key_75", "api_key_76", "api_key_77", "api_key_78", "api_key_79", "api_key_80", "api_key_81", "api_key_82", "api_key_83", "api_key_84", "api_key_85", "api_key_86", "api_key_87", "api_key_88", "api_key_89", "api_key_90", "api_key_91", "api_key_92", "api_key_93", "api_key_94", "api_key_95", "api_key_96", "api_key_97", "api_key_98", "api_key_99", "api_key_100"


        };
                private static string[] client_cashappdata01 =
                        {

        };
                private static string[] client_zelleappdata01 =
                        {
"(212) 555-0173","(305) 555-0142","(415) 555-0198","(619) 555-0183","(713) 555-0129",
    "(312) 555-0167","(702) 555-0118","(404) 555-0135","(503) 555-0179","(602) 555-0156",
    "(214) 555-0131","(310) 555-0191","(516) 555-0187","(407) 555-0149","(786) 555-0124",
    "(617) 555-0163","(503) 555-0151","(954) 555-0175","(916) 555-0139","(801) 555-0181",
    "(305) 555-0153","(312) 555-0197","(713) 555-0171","(602) 555-0161","(425) 555-0147",
    "(404) 555-0185","(907) 555-0115","(719) 555-0165","(970) 555-0133","(928) 555-0193",
    "(317) 555-0148","(617) 555-0182","(832) 555-0195","(404) 555-0127","(702) 555-0159",
    "(212) 555-0141","(407) 555-0177","(214) 555-0158","(803) 555-0132","(303) 555-0168",
    "(801) 555-0178","(678) 555-0126","(516) 555-0194","(312) 555-0119","(713) 555-0179",
    "(415) 555-0138","(305) 555-0172","(602) 555-0146","(303) 555-0190","(818) 555-0154",
    "(321) 555-0176","(215) 555-0188","(503) 555-0145","(954) 555-0169","(512) 555-0117",
    "(619) 555-0192","(404) 555-0162","(480) 555-0180","(713) 555-0143","(212) 555-0155",
    "(702) 555-0164","(617) 555-0196","(305) 555-0121","(818) 555-0113","(214) 555-0170",
    "(516) 555-0144","(425) 555-0134","(602) 555-0189","(312) 555-0152","(803) 555-0116",
    "(954) 555-0174","(801) 555-0188","(907) 555-0130","(615) 555-0174","(210) 555-0199",
    "(409) 555-0160","(702) 555-0122","(305) 555-0114","(617) 555-0186","(323) 555-0149",
    "(408) 555-0174","(801) 555-0166","(312) 555-0199","(702) 555-0150","(214) 555-0123",
    "(516) 555-0184","(404) 555-0170","(305) 555-0188","(212) 555-0136","(714) 555-0142"
        };
                private static string[] client_venmoappdata01 =
                        {

        };
                private static string[] client_paypalappdata01 =
                        {

        };
                private static string[] client_logo =
                        {
"/home/swageteam101/Pictures/celluloid-shot0001.jpg",
"/home/swageteam101/Pictures/Screenshot from 2026-04-26 11-00-28.png"
        };
                private static string[] client_latitude =
                        {
"100",
        "34.05",
        "51.50",
        "37.7755",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100",
        "34.05",
        "51.50",
        "37.7755",
        "100"
        };
                private static string[] client_longitude =
                     {
                        "200",
        "72.00",
        "7.48",
        "2.8837",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200",
        "2.8837",
        "7.48",
        "7.48",
        "200"

        };
                private static string[] client_primary_color =
                   {



        };
                private static string[] client_secondary_color =
                   {

        };
                private static string[] client_tertiary_color =
                     {

        };
                private static string[] client_social_media =
                   {
"Instagram",
"LinkedIn",
"Twitter",
"Facebook",
"TikTok",
"YouTube",
"Pinterest"

        };
                public static string[] client_type =
                {
"Tech & Innovation",
"Sustainable Living",
"Health & Wellness",
"Food & Beverage Delivery",
"Online Services",
"Pet & Animal Care",
"Renewable Energy Solutions",
"AI & Digital Marketing",
"E-commerce & Tech Platforms",
"Biotechnology & Health Tech",
"Creative Arts & Culture",
"Home & Personal Care",
"Travel & Tourism Services",
"Tech & IT Consulting",
"Education & Learning Platforms",
"Health & Fitness Technology",
"Pet & Animal Care",
"AI & Digital Marketing",
"Health & Wellness",
"Sustainable Living & Environment",
        };

                private static Random rnd = new Random();
                public string random_client_name => client_name[rnd.Next(client_name.Length)];
                public string random_client_emailaddress => client_emailaddress[rnd.Next(client_emailaddress.Length)];
                public string random_client_phonenumber => client_phonenumber[rnd.Next(client_phonenumber.Length)];
                public string random_client_api_key => client_api_key[rnd.Next(client_api_key.Length)];
                public string random_client_cashappdata01 => client_cashappdata01[rnd.Next(client_cashappdata01.Length)];
                public string random_client_zelleappdata01 => client_zelleappdata01[rnd.Next(client_zelleappdata01.Length)];
                public string random_client_venmoappdata01 => client_venmoappdata01[rnd.Next(client_venmoappdata01.Length)];
                public string random_client_paypalappdata01 => client_paypalappdata01[rnd.Next(client_paypalappdata01.Length)];
                public string random_client_logo => client_logo[rnd.Next(client_logo.Length)];
                public string random_client_latitude => client_latitude[rnd.Next(client_latitude.Length)];
                public string random_client_longitude => client_longitude[rnd.Next(client_longitude.Length)];
                public string random_client_primary_color => client_primary_color[rnd.Next(client_primary_color.Length)];
                public string random_client_secondary_color => client_secondary_color[rnd.Next(client_secondary_color.Length)];
                public string random_client_tertiary_color => client_tertiary_color[rnd.Next(client_tertiary_color.Length)];
                public string random_client_social_media => client_social_media[rnd.Next(client_social_media.Length)];
                public string random_client_type => client_type[rnd.Next(client_type.Length)];
        }
}
