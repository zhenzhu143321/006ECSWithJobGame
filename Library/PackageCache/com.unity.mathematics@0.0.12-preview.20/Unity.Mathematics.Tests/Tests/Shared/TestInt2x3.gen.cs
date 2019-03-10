// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt2x3
    {
        [TestCompiler]
        public static void int2x3_zero()
        {
            TestUtils.AreEqual(int2x3.zero.c0.x, 0);
            TestUtils.AreEqual(int2x3.zero.c0.y, 0);
            TestUtils.AreEqual(int2x3.zero.c1.x, 0);
            TestUtils.AreEqual(int2x3.zero.c1.y, 0);
            TestUtils.AreEqual(int2x3.zero.c2.x, 0);
            TestUtils.AreEqual(int2x3.zero.c2.y, 0);
        }

        [TestCompiler]
        public static void int2x3_operator_equal_wide_wide()
        {
            int2x3 a0 = int2x3(790229414, 970783976, 1428432738, 1578747135, 1733797753, 2001507228);
            int2x3 b0 = int2x3(612337669, 1214209108, 2120643427, 295461214, 1510890331, 1893316566);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2x3 a1 = int2x3(1446876437, 1777406370, 1426387268, 1809275021, 1843770816, 1172185222);
            int2x3 b1 = int2x3(921816149, 1834958575, 1482011863, 2062852792, 226398742, 770290735);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2x3 a2 = int2x3(1469608940, 869874758, 458603090, 581282460, 1948324909, 1129078206);
            int2x3 b2 = int2x3(36812057, 543224481, 1565350150, 1909926604, 1619900436, 1849990483);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2x3 a3 = int2x3(1638391029, 1135553683, 2079295200, 576232476, 608208235, 11172509);
            int2x3 b3 = int2x3(1261604411, 161864811, 843379453, 1780425458, 215681636, 2123130580);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_equal_wide_scalar()
        {
            int2x3 a0 = int2x3(1211464300, 1921862607, 508076684, 1249127920, 1394594555, 746862310);
            int b0 = (746972502);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2x3 a1 = int2x3(1733655277, 1682018538, 795585660, 936027116, 927605411, 672785749);
            int b1 = (1884008277);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2x3 a2 = int2x3(1465584610, 404448210, 969511077, 442746747, 1772925698, 1884034177);
            int b2 = (585324157);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2x3 a3 = int2x3(451512860, 1370577708, 597010220, 1249636005, 211986678, 1305479811);
            int b3 = (425476075);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_equal_scalar_wide()
        {
            int a0 = (1150044438);
            int2x3 b0 = int2x3(233855098, 924242519, 1402948791, 601381975, 2120518068, 629187703);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1971977031);
            int2x3 b1 = int2x3(47183124, 1061805787, 1009011238, 312511148, 1460673064, 737210539);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1737844479);
            int2x3 b2 = int2x3(1892405453, 2133024000, 455818693, 2003197687, 1276241219, 534746610);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (559824292);
            int2x3 b3 = int2x3(1758388240, 1023494292, 719963017, 1883763832, 597498209, 367814403);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_not_equal_wide_wide()
        {
            int2x3 a0 = int2x3(1660932106, 982847023, 97046264, 1739517447, 1253499180, 1830584069);
            int2x3 b0 = int2x3(107139049, 75478496, 2055495054, 358586687, 942338347, 111564990);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2x3 a1 = int2x3(1841470429, 1397841646, 1770890135, 1906548631, 169082967, 2099271786);
            int2x3 b1 = int2x3(113811950, 948912488, 1080084121, 1400504872, 1032134499, 1061123400);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2x3 a2 = int2x3(1909317609, 46519139, 1433204003, 931492669, 670504132, 1551558665);
            int2x3 b2 = int2x3(221862069, 858950046, 989094643, 2023070999, 1269317127, 531883744);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2x3 a3 = int2x3(1204055048, 1623586740, 226381077, 1145987803, 644253929, 475189890);
            int2x3 b3 = int2x3(687761409, 278427731, 296354221, 536981557, 1134676193, 1749879634);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_not_equal_wide_scalar()
        {
            int2x3 a0 = int2x3(747758183, 1033001286, 1439973882, 2138928797, 1197845089, 1432672459);
            int b0 = (248693828);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2x3 a1 = int2x3(950170763, 2105962247, 727205263, 1640688041, 276313906, 2126300423);
            int b1 = (238704450);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2x3 a2 = int2x3(791998981, 1171827730, 1412347883, 1622176923, 768370497, 1072798259);
            int b2 = (2035077187);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2x3 a3 = int2x3(1808712713, 1582645163, 1876273820, 90244766, 30493685, 904014575);
            int b3 = (1497830076);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_not_equal_scalar_wide()
        {
            int a0 = (2076921066);
            int2x3 b0 = int2x3(2037494727, 1989050616, 48833929, 1897435904, 514354517, 1783749164);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (364694471);
            int2x3 b1 = int2x3(754315072, 124108032, 1512967900, 1178825850, 1854793298, 50286949);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (2100802631);
            int2x3 b2 = int2x3(1640811853, 82110247, 472172806, 266984506, 2003668365, 1826089250);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (1041416160);
            int2x3 b3 = int2x3(356140110, 2057237962, 799920703, 1916347720, 510966350, 572038024);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_less_wide_wide()
        {
            int2x3 a0 = int2x3(1182186063, 415538999, 1667335818, 1566618442, 1166180837, 639095188);
            int2x3 b0 = int2x3(524633529, 1032195686, 760723389, 1505751409, 431962172, 1287906509);
            bool2x3 r0 = bool2x3(false, true, false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2x3 a1 = int2x3(1080836365, 771119973, 928263233, 789225474, 665243110, 1003542034);
            int2x3 b1 = int2x3(1560084663, 1450178202, 2066166337, 1107069023, 1640077524, 2103263105);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2x3 a2 = int2x3(1032480172, 1961336172, 923379558, 21210619, 1089772116, 1707633052);
            int2x3 b2 = int2x3(684229139, 1234033624, 1278743281, 1953079347, 1228832942, 2082539723);
            bool2x3 r2 = bool2x3(false, false, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2x3 a3 = int2x3(778986024, 158153146, 336715101, 1839141169, 1706859710, 1928438162);
            int2x3 b3 = int2x3(1088437561, 1058382082, 207459172, 750531081, 2015788562, 2126542133);
            bool2x3 r3 = bool2x3(true, true, false, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_less_wide_scalar()
        {
            int2x3 a0 = int2x3(608447185, 818840405, 869219329, 2080125385, 1214500548, 1361741203);
            int b0 = (1491216667);
            bool2x3 r0 = bool2x3(true, true, true, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2x3 a1 = int2x3(1667165786, 840091491, 469591900, 1247103789, 315321650, 930950514);
            int b1 = (1615392341);
            bool2x3 r1 = bool2x3(false, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2x3 a2 = int2x3(1100560246, 908563901, 1127696709, 1286331950, 380753337, 971148054);
            int b2 = (933855388);
            bool2x3 r2 = bool2x3(false, true, false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int2x3 a3 = int2x3(1827886929, 1579735991, 689044913, 1960894027, 371987110, 867559111);
            int b3 = (1056649851);
            bool2x3 r3 = bool2x3(false, false, true, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_less_scalar_wide()
        {
            int a0 = (548436837);
            int2x3 b0 = int2x3(282703327, 14370648, 1862117300, 1304793311, 826073259, 988910157);
            bool2x3 r0 = bool2x3(false, false, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (445132446);
            int2x3 b1 = int2x3(1139670255, 111349251, 1102440676, 112183144, 1594415311, 1890019295);
            bool2x3 r1 = bool2x3(true, false, true, false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (2098715503);
            int2x3 b2 = int2x3(608933527, 183989010, 1596056507, 1027318999, 146281093, 358911716);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (874278078);
            int2x3 b3 = int2x3(1106057699, 1256807459, 2111973919, 1736480659, 810406400, 1329939911);
            bool2x3 r3 = bool2x3(true, true, true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_greater_wide_wide()
        {
            int2x3 a0 = int2x3(592884447, 2133928932, 918957182, 1284069471, 194584707, 739120780);
            int2x3 b0 = int2x3(138737040, 192863971, 1700841444, 1044631301, 1391589821, 730837695);
            bool2x3 r0 = bool2x3(true, true, false, true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int2x3 a1 = int2x3(241654068, 1340158550, 2099542537, 1182623667, 1399607274, 789301637);
            int2x3 b1 = int2x3(253553987, 2078872742, 910845808, 976047676, 202633078, 1223618940);
            bool2x3 r1 = bool2x3(false, false, true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int2x3 a2 = int2x3(180400925, 594688333, 1877031463, 1360073500, 1091782422, 546676424);
            int2x3 b2 = int2x3(641600530, 1830470354, 1570701388, 1104256103, 1838646932, 740166101);
            bool2x3 r2 = bool2x3(false, false, true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2x3 a3 = int2x3(348221770, 716039145, 458742739, 1365508046, 1523167942, 1574478622);
            int2x3 b3 = int2x3(1549021845, 1457092873, 1790630950, 907793213, 555122804, 1418910265);
            bool2x3 r3 = bool2x3(false, false, false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_greater_wide_scalar()
        {
            int2x3 a0 = int2x3(1097138316, 211763648, 1883002501, 56406996, 43662641, 1923456111);
            int b0 = (438688675);
            bool2x3 r0 = bool2x3(true, false, true, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int2x3 a1 = int2x3(1437755186, 2125058448, 304028799, 893125636, 48044515, 711945018);
            int b1 = (1219010035);
            bool2x3 r1 = bool2x3(true, true, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int2x3 a2 = int2x3(1035679270, 572743717, 1016617211, 2063134811, 1577403353, 64009107);
            int b2 = (577943770);
            bool2x3 r2 = bool2x3(true, false, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2x3 a3 = int2x3(1462961460, 3715845, 689362811, 263973424, 1045140419, 1058332184);
            int b3 = (1143565920);
            bool2x3 r3 = bool2x3(true, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_greater_scalar_wide()
        {
            int a0 = (2024896938);
            int2x3 b0 = int2x3(599356784, 185671342, 1932327391, 2025591013, 1257191721, 1312388500);
            bool2x3 r0 = bool2x3(true, true, true, false, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1443698859);
            int2x3 b1 = int2x3(779217735, 691047512, 741776730, 732565983, 668302204, 1556466996);
            bool2x3 r1 = bool2x3(true, true, true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (858599525);
            int2x3 b2 = int2x3(1896917159, 701542098, 1052151621, 1023307544, 1435392907, 1858177345);
            bool2x3 r2 = bool2x3(false, true, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (299897686);
            int2x3 b3 = int2x3(632930355, 1387203601, 483722222, 863042711, 1713088900, 315569296);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_less_equal_wide_wide()
        {
            int2x3 a0 = int2x3(1577248162, 2043073061, 1688380407, 176431985, 223299035, 1502802140);
            int2x3 b0 = int2x3(903445031, 2108974565, 210822256, 1281704747, 453681718, 66138830);
            bool2x3 r0 = bool2x3(false, true, false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2x3 a1 = int2x3(1691709825, 386789394, 117182003, 1665770435, 1958490731, 420032601);
            int2x3 b1 = int2x3(1229799377, 1620922595, 1715833766, 1366430432, 13102000, 46919981);
            bool2x3 r1 = bool2x3(false, true, true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2x3 a2 = int2x3(1251092689, 2011681765, 749743684, 183784440, 1150674774, 1633828822);
            int2x3 b2 = int2x3(486470891, 1709514236, 2145785285, 854254454, 1273278658, 810263315);
            bool2x3 r2 = bool2x3(false, false, true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2x3 a3 = int2x3(1719442172, 336047314, 743733218, 1393995865, 1854442658, 1498138884);
            int2x3 b3 = int2x3(1862773824, 201799013, 974166844, 1320622967, 2058099616, 522102017);
            bool2x3 r3 = bool2x3(true, false, true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_less_equal_wide_scalar()
        {
            int2x3 a0 = int2x3(1722165358, 1219858357, 860410743, 411099660, 348104022, 1963256951);
            int b0 = (1688048545);
            bool2x3 r0 = bool2x3(false, true, true, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2x3 a1 = int2x3(212084836, 1459242706, 1745758438, 532949158, 262559763, 690091301);
            int b1 = (58924407);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2x3 a2 = int2x3(1806172431, 1857173043, 1617221948, 2017733017, 804204255, 981729559);
            int b2 = (2091514001);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2x3 a3 = int2x3(2032949254, 2079225209, 26179915, 238796519, 1917813750, 1258115260);
            int b3 = (910922522);
            bool2x3 r3 = bool2x3(false, false, true, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_less_equal_scalar_wide()
        {
            int a0 = (1777585);
            int2x3 b0 = int2x3(1181030049, 1787703989, 1729760948, 1816537388, 1359786460, 874999193);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1678863148);
            int2x3 b1 = int2x3(1711365839, 762067160, 11953554, 1131583906, 1175393186, 1293698493);
            bool2x3 r1 = bool2x3(true, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (48893340);
            int2x3 b2 = int2x3(66196247, 1958607116, 1576473309, 861890786, 478252419, 957887737);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (117849810);
            int2x3 b3 = int2x3(1348693584, 105489302, 259034238, 530713566, 601413850, 830430286);
            bool2x3 r3 = bool2x3(true, false, true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_greater_equal_wide_wide()
        {
            int2x3 a0 = int2x3(263000030, 744235661, 1893760267, 237248, 1062370984, 1676977687);
            int2x3 b0 = int2x3(1395535146, 1178373944, 1237373760, 1364855321, 600811864, 362060472);
            bool2x3 r0 = bool2x3(false, false, true, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2x3 a1 = int2x3(816766880, 1089431546, 1394493730, 1176473380, 1193988637, 1703862455);
            int2x3 b1 = int2x3(290870624, 1839067862, 396958580, 1336888643, 1019684398, 1697684196);
            bool2x3 r1 = bool2x3(true, false, true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2x3 a2 = int2x3(1806186947, 1253571980, 589397635, 1951842887, 798931197, 808426484);
            int2x3 b2 = int2x3(1227300220, 2044269675, 1898323839, 874509380, 1873505472, 1268843918);
            bool2x3 r2 = bool2x3(true, false, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2x3 a3 = int2x3(744869638, 1959531616, 207430702, 1533946595, 1148381840, 2011549474);
            int2x3 b3 = int2x3(1606949562, 1263896445, 1805518202, 1412091359, 1240330374, 1955056253);
            bool2x3 r3 = bool2x3(false, true, false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_greater_equal_wide_scalar()
        {
            int2x3 a0 = int2x3(2112791350, 1043657935, 101764761, 1529909067, 556026890, 281734132);
            int b0 = (1470533736);
            bool2x3 r0 = bool2x3(true, false, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2x3 a1 = int2x3(1186600258, 609211196, 1604309397, 829548642, 244604867, 1419295004);
            int b1 = (815093894);
            bool2x3 r1 = bool2x3(true, false, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2x3 a2 = int2x3(471843809, 1460027917, 1646290021, 196833647, 1596738181, 1905036391);
            int b2 = (1819986195);
            bool2x3 r2 = bool2x3(false, false, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2x3 a3 = int2x3(1771391775, 370941146, 440219668, 1607345862, 1449142607, 1223010129);
            int b3 = (1584946560);
            bool2x3 r3 = bool2x3(true, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_greater_equal_scalar_wide()
        {
            int a0 = (1525542481);
            int2x3 b0 = int2x3(1503244746, 861711266, 817773856, 925984572, 571221723, 683686810);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (118252990);
            int2x3 b1 = int2x3(1653952090, 1240253990, 1947039008, 1869136019, 152012637, 1214546726);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (917376832);
            int2x3 b2 = int2x3(303549425, 2111728811, 945321577, 173706579, 625318949, 519443238);
            bool2x3 r2 = bool2x3(true, false, false, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1583588379);
            int2x3 b3 = int2x3(1026799433, 1713083717, 394922760, 1216218189, 1336522452, 233894308);
            bool2x3 r3 = bool2x3(true, false, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_add_wide_wide()
        {
            int2x3 a0 = int2x3(2049228671, 1658660009, 491719392, 937013355, 81108663, 1063894558);
            int2x3 b0 = int2x3(2088751567, 645762023, 306868786, 4360271, 506047997, 2094559874);
            int2x3 r0 = int2x3(-156987058, -1990545264, 798588178, 941373626, 587156660, -1136512864);
            TestUtils.AreEqual(a0 + b0, r0);

            int2x3 a1 = int2x3(86954702, 843159721, 698977704, 192867135, 1683407172, 137301303);
            int2x3 b1 = int2x3(1634712736, 1601474440, 1586485231, 908746788, 1812370320, 1247342357);
            int2x3 r1 = int2x3(1721667438, -1850333135, -2009504361, 1101613923, -799189804, 1384643660);
            TestUtils.AreEqual(a1 + b1, r1);

            int2x3 a2 = int2x3(2103582820, 526139155, 447937230, 2127411006, 1670579390, 1914969141);
            int2x3 b2 = int2x3(2043773873, 223363428, 175115707, 985928617, 507662836, 1231457019);
            int2x3 r2 = int2x3(-147610603, 749502583, 623052937, -1181627673, -2116725070, -1148541136);
            TestUtils.AreEqual(a2 + b2, r2);

            int2x3 a3 = int2x3(997691756, 857841794, 2129024875, 267535529, 978891383, 657092366);
            int2x3 b3 = int2x3(776127866, 607782424, 1160366210, 1384832242, 702057048, 703554905);
            int2x3 r3 = int2x3(1773819622, 1465624218, -1005576211, 1652367771, 1680948431, 1360647271);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_add_wide_scalar()
        {
            int2x3 a0 = int2x3(2038218457, 134923711, 875689667, 1338884463, 997710928, 340490871);
            int b0 = (2124409227);
            int2x3 r0 = int2x3(-132339612, -2035634358, -1294868402, -831673606, -1172847141, -1830067198);
            TestUtils.AreEqual(a0 + b0, r0);

            int2x3 a1 = int2x3(1067888129, 2003021861, 1635971971, 1160398286, 85446202, 1068152966);
            int b1 = (70433301);
            int2x3 r1 = int2x3(1138321430, 2073455162, 1706405272, 1230831587, 155879503, 1138586267);
            TestUtils.AreEqual(a1 + b1, r1);

            int2x3 a2 = int2x3(1239387100, 1727477485, 1095438654, 756559204, 1818718931, 658923552);
            int b2 = (1497676888);
            int2x3 r2 = int2x3(-1557903308, -1069812923, -1701851754, -2040731204, -978571477, -2138366856);
            TestUtils.AreEqual(a2 + b2, r2);

            int2x3 a3 = int2x3(1610518921, 692843300, 1068593469, 1704776233, 577782260, 736972565);
            int b3 = (1585755398);
            int2x3 r3 = int2x3(-1098692977, -2016368598, -1640618429, -1004435665, -2131429638, -1972239333);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_add_scalar_wide()
        {
            int a0 = (391092078);
            int2x3 b0 = int2x3(519908870, 851424292, 328314822, 135622204, 740923360, 655394201);
            int2x3 r0 = int2x3(911000948, 1242516370, 719406900, 526714282, 1132015438, 1046486279);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (1451896269);
            int2x3 b1 = int2x3(1781697072, 996031825, 1557774949, 779774940, 1111541302, 783046445);
            int2x3 r1 = int2x3(-1061373955, -1847039202, -1285296078, -2063296087, -1731529725, -2060024582);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1130163944);
            int2x3 b2 = int2x3(288279584, 1397683861, 1636583489, 673263339, 1469300874, 14855965);
            int2x3 r2 = int2x3(1418443528, -1767119491, -1528219863, 1803427283, -1695502478, 1145019909);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (1116636999);
            int2x3 b3 = int2x3(1488863300, 1600990886, 190651301, 1307459768, 920085839, 2082229835);
            int2x3 r3 = int2x3(-1689466997, -1577339411, 1307288300, -1870870529, 2036722838, -1096100462);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_sub_wide_wide()
        {
            int2x3 a0 = int2x3(1353441118, 797269833, 659988112, 56022121, 365847472, 2062899435);
            int2x3 b0 = int2x3(1332656812, 1827794007, 972557431, 2078233689, 1508184327, 1372307701);
            int2x3 r0 = int2x3(20784306, -1030524174, -312569319, -2022211568, -1142336855, 690591734);
            TestUtils.AreEqual(a0 - b0, r0);

            int2x3 a1 = int2x3(1380988474, 799885138, 1306058185, 579775276, 1239163824, 344591081);
            int2x3 b1 = int2x3(810327977, 936799885, 71562303, 1418723328, 1971342989, 1226053395);
            int2x3 r1 = int2x3(570660497, -136914747, 1234495882, -838948052, -732179165, -881462314);
            TestUtils.AreEqual(a1 - b1, r1);

            int2x3 a2 = int2x3(86359575, 1049709943, 721529513, 1767221271, 7652784, 545192611);
            int2x3 b2 = int2x3(136565478, 1979903295, 600719425, 837912956, 632054793, 711091688);
            int2x3 r2 = int2x3(-50205903, -930193352, 120810088, 929308315, -624402009, -165899077);
            TestUtils.AreEqual(a2 - b2, r2);

            int2x3 a3 = int2x3(176298787, 1477774126, 1426963688, 2032787858, 2059525977, 445200454);
            int2x3 b3 = int2x3(904695656, 1640069560, 750244414, 1385118097, 1102391291, 1221949855);
            int2x3 r3 = int2x3(-728396869, -162295434, 676719274, 647669761, 957134686, -776749401);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_sub_wide_scalar()
        {
            int2x3 a0 = int2x3(1176369558, 1934521195, 309452150, 1417634074, 108910717, 1306356714);
            int b0 = (462232403);
            int2x3 r0 = int2x3(714137155, 1472288792, -152780253, 955401671, -353321686, 844124311);
            TestUtils.AreEqual(a0 - b0, r0);

            int2x3 a1 = int2x3(1502312334, 281174200, 87530840, 1913724431, 2041593336, 557239990);
            int b1 = (1451794815);
            int2x3 r1 = int2x3(50517519, -1170620615, -1364263975, 461929616, 589798521, -894554825);
            TestUtils.AreEqual(a1 - b1, r1);

            int2x3 a2 = int2x3(1119051448, 819090189, 816382635, 815920639, 1829033117, 1792801932);
            int b2 = (1590376732);
            int2x3 r2 = int2x3(-471325284, -771286543, -773994097, -774456093, 238656385, 202425200);
            TestUtils.AreEqual(a2 - b2, r2);

            int2x3 a3 = int2x3(1113440549, 1277257189, 2092779398, 642236742, 1605250794, 819644478);
            int b3 = (1418937976);
            int2x3 r3 = int2x3(-305497427, -141680787, 673841422, -776701234, 186312818, -599293498);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_sub_scalar_wide()
        {
            int a0 = (1691534405);
            int2x3 b0 = int2x3(2022393810, 1612688515, 496689713, 887037586, 2097630964, 374934538);
            int2x3 r0 = int2x3(-330859405, 78845890, 1194844692, 804496819, -406096559, 1316599867);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (939035482);
            int2x3 b1 = int2x3(935242277, 1789300421, 264712893, 1231856067, 1818112748, 1428436109);
            int2x3 r1 = int2x3(3793205, -850264939, 674322589, -292820585, -879077266, -489400627);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1258745460);
            int2x3 b2 = int2x3(1077380396, 1330722719, 518111829, 967128529, 344666254, 1082267918);
            int2x3 r2 = int2x3(181365064, -71977259, 740633631, 291616931, 914079206, 176477542);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (907866696);
            int2x3 b3 = int2x3(1816885123, 460340568, 962154498, 557113461, 1701216709, 1980098777);
            int2x3 r3 = int2x3(-909018427, 447526128, -54287802, 350753235, -793350013, -1072232081);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_mul_wide_wide()
        {
            int2x3 a0 = int2x3(245827027, 208934650, 1019478917, 568231809, 877289039, 1585782440);
            int2x3 b0 = int2x3(759663997, 350129201, 477450108, 1635735015, 388710278, 757722665);
            int2x3 r0 = int2x3(-632811769, 1402281434, 332447596, -1932977561, -1670918566, 1455036648);
            TestUtils.AreEqual(a0 * b0, r0);

            int2x3 a1 = int2x3(2111178729, 1186019069, 571481445, 1570087048, 629447153, 619383734);
            int2x3 b1 = int2x3(1509388321, 1841703980, 1826369331, 1524322467, 1605207974, 428419155);
            int2x3 r1 = int2x3(2128344329, -594088068, -1654168033, 2093463192, -1207506618, -1133560830);
            TestUtils.AreEqual(a1 * b1, r1);

            int2x3 a2 = int2x3(2055121568, 700402816, 263414349, 187830569, 2048056680, 546694675);
            int2x3 b2 = int2x3(1460605791, 1968043860, 771161742, 2037340417, 322304267, 651448359);
            int2x3 r2 = int2x3(990589280, -938173952, -1341723466, 1156600361, 649177976, 678952165);
            TestUtils.AreEqual(a2 * b2, r2);

            int2x3 a3 = int2x3(853585367, 933370718, 990212476, 1915885905, 1984212358, 368146234);
            int2x3 b3 = int2x3(1608326767, 1427155898, 1092185338, 665119139, 223634707, 694718952);
            int2x3 r3 = int2x3(1063621177, -1611682740, -2142428392, -573253741, -1652113678, 1626072720);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_mul_wide_scalar()
        {
            int2x3 a0 = int2x3(1762033447, 465343930, 1570757881, 1326409563, 1824319147, 1356578909);
            int b0 = (1476837906);
            int2x3 r0 = int2x3(-1313177922, 1326807828, -2138555518, -276153754, -65548794, -1318584182);
            TestUtils.AreEqual(a0 * b0, r0);

            int2x3 a1 = int2x3(72749215, 975743632, 573770299, 1958912969, 971327747, 1818877398);
            int b1 = (154616909);
            int2x3 r1 = int2x3(1400257491, 7966032, 499040191, 322676597, 469811687, -373386914);
            TestUtils.AreEqual(a1 * b1, r1);

            int2x3 a2 = int2x3(1324050764, 1279757657, 391009467, 1186856590, 890343818, 800117742);
            int b2 = (660611671);
            int2x3 r2 = int2x3(645718228, -42542273, -1778409075, 1570790978, -133379610, 1820172770);
            TestUtils.AreEqual(a2 * b2, r2);

            int2x3 a3 = int2x3(606927173, 1688964615, 1439447294, 387721300, 1192501703, 1613845584);
            int b3 = (1338014500);
            int2x3 r3 = int2x3(-254331724, 1134384636, 1352273336, -229242928, 1766808828, 645024576);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_mul_scalar_wide()
        {
            int a0 = (99541948);
            int2x3 b0 = int2x3(1764461774, 657072478, 1459784358, 1610646683, 1632058826, 868441654);
            int2x3 r0 = int2x3(-950398648, -102049016, 1260585960, 1158730452, -1606056, -466153048);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (1408757883);
            int2x3 b1 = int2x3(335917146, 2105124483, 1178393968, 1963904348, 1409533767, 243286231);
            int2x3 r1 = int2x3(1223039806, 1995624689, -974691120, 375843636, 858017565, 2027534157);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (1336308795);
            int2x3 b2 = int2x3(517963367, 1733623488, 459880225, 994616533, 1420531535, 1821413700);
            int2x3 r2 = int2x3(580046269, -997870016, -325015397, 831291671, -1034573003, -1254339924);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (677771573);
            int2x3 b3 = int2x3(2132626845, 1158827713, 640102997, 944551639, 1323243330, 1186460236);
            int2x3 r3 = int2x3(-125843839, 1435043573, 698030233, 9173379, -824638806, 113055164);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_div_wide_wide()
        {
            int2x3 a0 = int2x3(1590198532, 507812502, 126627032, 1058247011, 427387861, 290676154);
            int2x3 b0 = int2x3(1434703236, 911965201, 390415521, 128746927, 525835375, 816946613);
            int2x3 r0 = int2x3(1, 0, 0, 8, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2x3 a1 = int2x3(1829594484, 1127868739, 499016351, 1341209632, 134906097, 785470242);
            int2x3 b1 = int2x3(878264647, 146789678, 2089524057, 254213018, 1916850021, 1737806518);
            int2x3 r1 = int2x3(2, 7, 0, 5, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int2x3 a2 = int2x3(788249865, 1099825433, 1552968283, 1822367139, 1021812060, 1937073018);
            int2x3 b2 = int2x3(1906634983, 437754923, 825037958, 902508708, 896853614, 49452028);
            int2x3 r2 = int2x3(0, 2, 1, 2, 1, 39);
            TestUtils.AreEqual(a2 / b2, r2);

            int2x3 a3 = int2x3(645757349, 1097576782, 1246027674, 1152153253, 1900577195, 172149343);
            int2x3 b3 = int2x3(1921327824, 787000669, 1032149621, 858558868, 1422112429, 837098844);
            int2x3 r3 = int2x3(0, 1, 1, 1, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_div_wide_scalar()
        {
            int2x3 a0 = int2x3(560951562, 1218680769, 375341724, 1613542090, 1919409166, 1397425408);
            int b0 = (947861580);
            int2x3 r0 = int2x3(0, 1, 0, 1, 2, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int2x3 a1 = int2x3(1349573078, 341995568, 495895326, 1515313790, 1676971657, 2131487088);
            int b1 = (524526253);
            int2x3 r1 = int2x3(2, 0, 0, 2, 3, 4);
            TestUtils.AreEqual(a1 / b1, r1);

            int2x3 a2 = int2x3(2105094094, 542666029, 1646044372, 1447236569, 107215658, 19616726);
            int b2 = (1017891310);
            int2x3 r2 = int2x3(2, 0, 1, 1, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2x3 a3 = int2x3(896899915, 1249475421, 1486968988, 1738891885, 1919705924, 1244966864);
            int b3 = (707389627);
            int2x3 r3 = int2x3(1, 1, 2, 2, 2, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_div_scalar_wide()
        {
            int a0 = (1161272038);
            int2x3 b0 = int2x3(187325733, 1594107378, 2016183849, 1589343709, 388768753, 1417077283);
            int2x3 r0 = int2x3(6, 0, 0, 0, 2, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (1773486938);
            int2x3 b1 = int2x3(1154044032, 81831373, 1476877645, 653688843, 45756703, 631027637);
            int2x3 r1 = int2x3(1, 21, 1, 2, 38, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (396671391);
            int2x3 b2 = int2x3(784365696, 1250594097, 1818363859, 1653451772, 270557729, 48974453);
            int2x3 r2 = int2x3(0, 0, 0, 0, 1, 8);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (1796936382);
            int2x3 b3 = int2x3(1427856423, 981056957, 1955700573, 705450043, 1054404890, 351914083);
            int2x3 r3 = int2x3(1, 1, 0, 2, 1, 5);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_mod_wide_wide()
        {
            int2x3 a0 = int2x3(146150818, 1846543305, 1071447756, 308965362, 659881575, 1002365460);
            int2x3 b0 = int2x3(983050390, 771341152, 942375212, 367361754, 749500619, 750718852);
            int2x3 r0 = int2x3(146150818, 303861001, 129072544, 308965362, 659881575, 251646608);
            TestUtils.AreEqual(a0 % b0, r0);

            int2x3 a1 = int2x3(861198439, 1510617532, 778525078, 1458458044, 101987897, 1249565173);
            int2x3 b1 = int2x3(2095151755, 88438806, 769227442, 647214624, 1026513788, 1544950956);
            int2x3 r1 = int2x3(861198439, 7157830, 9297636, 164028796, 101987897, 1249565173);
            TestUtils.AreEqual(a1 % b1, r1);

            int2x3 a2 = int2x3(938026607, 1692541775, 1518877124, 1806965510, 1325139851, 994457255);
            int2x3 b2 = int2x3(160166322, 1099108075, 1158422232, 1798905209, 164686701, 327889784);
            int2x3 r2 = int2x3(137194997, 593433700, 360454892, 8060301, 7646243, 10787903);
            TestUtils.AreEqual(a2 % b2, r2);

            int2x3 a3 = int2x3(1372400564, 1770508529, 100255877, 452674793, 1545968777, 629019189);
            int2x3 b3 = int2x3(1082162785, 1213537518, 608481038, 329133821, 1824387961, 1223426748);
            int2x3 r3 = int2x3(290237779, 556971011, 100255877, 123540972, 1545968777, 629019189);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_mod_wide_scalar()
        {
            int2x3 a0 = int2x3(164800505, 1062177828, 1898749675, 1701653318, 820393245, 19002208);
            int b0 = (883951171);
            int2x3 r0 = int2x3(164800505, 178226657, 130847333, 817702147, 820393245, 19002208);
            TestUtils.AreEqual(a0 % b0, r0);

            int2x3 a1 = int2x3(128329633, 896587769, 405208598, 1982762194, 959236935, 712321026);
            int b1 = (1464010899);
            int2x3 r1 = int2x3(128329633, 896587769, 405208598, 518751295, 959236935, 712321026);
            TestUtils.AreEqual(a1 % b1, r1);

            int2x3 a2 = int2x3(172564850, 1085897743, 1607489717, 165478511, 647846716, 915707999);
            int b2 = (1540068445);
            int2x3 r2 = int2x3(172564850, 1085897743, 67421272, 165478511, 647846716, 915707999);
            TestUtils.AreEqual(a2 % b2, r2);

            int2x3 a3 = int2x3(1602830401, 1084934806, 488509689, 2087820912, 377501313, 1778384846);
            int b3 = (928191283);
            int2x3 r3 = int2x3(674639118, 156743523, 488509689, 231438346, 377501313, 850193563);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_mod_scalar_wide()
        {
            int a0 = (242383789);
            int2x3 b0 = int2x3(740000543, 1556450291, 1104736385, 437976569, 1911837205, 1507212038);
            int2x3 r0 = int2x3(242383789, 242383789, 242383789, 242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1906405167);
            int2x3 b1 = int2x3(247693265, 293460573, 1495295166, 873323603, 530681233, 1298102643);
            int2x3 r1 = int2x3(172552312, 145641729, 411110001, 159757961, 314361468, 608302524);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (2057984657);
            int2x3 b2 = int2x3(1000742091, 1461372131, 1859742342, 797184687, 821888842, 1083192997);
            int2x3 r2 = int2x3(56500475, 596612526, 198242315, 463615283, 414206973, 974791660);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (840114986);
            int2x3 b3 = int2x3(1894865954, 615159964, 1485575122, 2028738, 2122220318, 164578061);
            int2x3 r3 = int2x3(840114986, 224955022, 840114986, 217454, 840114986, 17224681);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_plus()
        {
            int2x3 a0 = int2x3(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272);
            int2x3 r0 = int2x3(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272);
            TestUtils.AreEqual(+a0, r0);

            int2x3 a1 = int2x3(1472881565, 401565897, 1287765427, 849339193, 174532915, 1864850812);
            int2x3 r1 = int2x3(1472881565, 401565897, 1287765427, 849339193, 174532915, 1864850812);
            TestUtils.AreEqual(+a1, r1);

            int2x3 a2 = int2x3(1566098441, 1615499926, 2049663954, 1723005749, 409076474, 591286416);
            int2x3 r2 = int2x3(1566098441, 1615499926, 2049663954, 1723005749, 409076474, 591286416);
            TestUtils.AreEqual(+a2, r2);

            int2x3 a3 = int2x3(1706631096, 1808261782, 1201290141, 82958939, 308695413, 1575280693);
            int2x3 r3 = int2x3(1706631096, 1808261782, 1201290141, 82958939, 308695413, 1575280693);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_neg()
        {
            int2x3 a0 = int2x3(1955022112, 662160019, 370300775, 2141283773, 1004505619, 28153593);
            int2x3 r0 = int2x3(-1955022112, -662160019, -370300775, -2141283773, -1004505619, -28153593);
            TestUtils.AreEqual(-a0, r0);

            int2x3 a1 = int2x3(33894270, 1115028238, 1636274969, 694995093, 1542206286, 213087293);
            int2x3 r1 = int2x3(-33894270, -1115028238, -1636274969, -694995093, -1542206286, -213087293);
            TestUtils.AreEqual(-a1, r1);

            int2x3 a2 = int2x3(243937487, 841085242, 574159094, 1687250035, 2057919693, 1175014732);
            int2x3 r2 = int2x3(-243937487, -841085242, -574159094, -1687250035, -2057919693, -1175014732);
            TestUtils.AreEqual(-a2, r2);

            int2x3 a3 = int2x3(1259809073, 1190569920, 2047955772, 2120729864, 1440774928, 1485596454);
            int2x3 r3 = int2x3(-1259809073, -1190569920, -2047955772, -2120729864, -1440774928, -1485596454);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_prefix_inc()
        {
            int2x3 a0 = int2x3(864455342, 2035793213, 1275443862, 971919915, 411610189, 446210725);
            int2x3 r0 = int2x3(864455343, 2035793214, 1275443863, 971919916, 411610190, 446210726);
            TestUtils.AreEqual(++a0, r0);

            int2x3 a1 = int2x3(395072276, 913293639, 432884105, 1208161871, 1385544935, 1835605516);
            int2x3 r1 = int2x3(395072277, 913293640, 432884106, 1208161872, 1385544936, 1835605517);
            TestUtils.AreEqual(++a1, r1);

            int2x3 a2 = int2x3(831396561, 696475402, 1786514683, 993189311, 752093909, 1622410417);
            int2x3 r2 = int2x3(831396562, 696475403, 1786514684, 993189312, 752093910, 1622410418);
            TestUtils.AreEqual(++a2, r2);

            int2x3 a3 = int2x3(1398865015, 1705625817, 609525897, 172599489, 504806865, 519296647);
            int2x3 r3 = int2x3(1398865016, 1705625818, 609525898, 172599490, 504806866, 519296648);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_postfix_inc()
        {
            int2x3 a0 = int2x3(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936);
            int2x3 r0 = int2x3(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936);
            TestUtils.AreEqual(a0++, r0);

            int2x3 a1 = int2x3(1643023524, 1396179607, 708474528, 177416855, 1524860667, 1408994706);
            int2x3 r1 = int2x3(1643023524, 1396179607, 708474528, 177416855, 1524860667, 1408994706);
            TestUtils.AreEqual(a1++, r1);

            int2x3 a2 = int2x3(375284401, 1676086778, 717006530, 506142468, 732199129, 2026873940);
            int2x3 r2 = int2x3(375284401, 1676086778, 717006530, 506142468, 732199129, 2026873940);
            TestUtils.AreEqual(a2++, r2);

            int2x3 a3 = int2x3(130175844, 420613464, 1219979307, 586574160, 357567451, 1468020171);
            int2x3 r3 = int2x3(130175844, 420613464, 1219979307, 586574160, 357567451, 1468020171);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_prefix_dec()
        {
            int2x3 a0 = int2x3(200904609, 871077500, 968578728, 638967721, 1995396216, 435367037);
            int2x3 r0 = int2x3(200904608, 871077499, 968578727, 638967720, 1995396215, 435367036);
            TestUtils.AreEqual(--a0, r0);

            int2x3 a1 = int2x3(1782514098, 1434377580, 596759698, 1699290403, 1758478358, 1914114460);
            int2x3 r1 = int2x3(1782514097, 1434377579, 596759697, 1699290402, 1758478357, 1914114459);
            TestUtils.AreEqual(--a1, r1);

            int2x3 a2 = int2x3(71237375, 1022184392, 1310293956, 356565557, 18299409, 906734601);
            int2x3 r2 = int2x3(71237374, 1022184391, 1310293955, 356565556, 18299408, 906734600);
            TestUtils.AreEqual(--a2, r2);

            int2x3 a3 = int2x3(799006218, 1040798388, 1469596990, 1719228297, 220897829, 1454322707);
            int2x3 r3 = int2x3(799006217, 1040798387, 1469596989, 1719228296, 220897828, 1454322706);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_postfix_dec()
        {
            int2x3 a0 = int2x3(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498);
            int2x3 r0 = int2x3(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498);
            TestUtils.AreEqual(a0--, r0);

            int2x3 a1 = int2x3(484207852, 691209285, 2017728859, 802721301, 377162390, 526366486);
            int2x3 r1 = int2x3(484207852, 691209285, 2017728859, 802721301, 377162390, 526366486);
            TestUtils.AreEqual(a1--, r1);

            int2x3 a2 = int2x3(1504625034, 60677868, 1867810045, 2095777993, 670715645, 324944916);
            int2x3 r2 = int2x3(1504625034, 60677868, 1867810045, 2095777993, 670715645, 324944916);
            TestUtils.AreEqual(a2--, r2);

            int2x3 a3 = int2x3(242636153, 1316734088, 1030072405, 1751972064, 1868889881, 1726583208);
            int2x3 r3 = int2x3(242636153, 1316734088, 1030072405, 1751972064, 1868889881, 1726583208);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_and_wide_wide()
        {
            int2x3 a0 = int2x3(779935043, 1097962163, 1939593304, 800599247, 952140918, 782792558);
            int2x3 b0 = int2x3(307705143, 1710882162, 866836769, 532490608, 679371720, 1794035877);
            int2x3 r0 = int2x3(39064835, 1097961522, 864731136, 263727168, 675283008, 715673636);
            TestUtils.AreEqual(a0 & b0, r0);

            int2x3 a1 = int2x3(1608557706, 396446406, 2039894114, 1286974642, 442394124, 1759739564);
            int2x3 b1 = int2x3(1439832202, 519529812, 23633139, 1209152681, 646737179, 1255867027);
            int2x3 r1 = int2x3(1438646410, 379666500, 16781410, 1209017504, 34366472, 1220739712);
            TestUtils.AreEqual(a1 & b1, r1);

            int2x3 a2 = int2x3(233435438, 665207770, 1942050241, 1022352952, 60340400, 329119345);
            int2x3 b2 = int2x3(1900854122, 413173763, 1409138251, 2087190272, 563439483, 354579077);
            int2x3 r2 = int2x3(21541162, 10485762, 1405162561, 1013440000, 26222640, 285241857);
            TestUtils.AreEqual(a2 & b2, r2);

            int2x3 a3 = int2x3(406517382, 1126764634, 343425836, 1957552749, 1624478957, 341972372);
            int2x3 b3 = int2x3(642224854, 1650432515, 755290290, 902865191, 661389406, 2134212586);
            int2x3 r3 = int2x3(168582, 1107890178, 67125280, 880844837, 541065292, 337646976);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_and_wide_scalar()
        {
            int2x3 a0 = int2x3(443615469, 490057985, 2042441263, 1524760558, 1405175110, 510212004);
            int b0 = (93423598);
            int2x3 r0 = int2x3(1114348, 85033216, 26281518, 8488942, 25232710, 67176356);
            TestUtils.AreEqual(a0 & b0, r0);

            int2x3 a1 = int2x3(1941875181, 1365509729, 428270198, 607982857, 650270920, 1249238550);
            int b1 = (1236735839);
            int2x3 r1 = int2x3(1102446925, 1092879937, 159777366, 3478793, 8523848, 1211438614);
            TestUtils.AreEqual(a1 & b1, r1);

            int2x3 a2 = int2x3(814629680, 143502472, 861733033, 1408932942, 957693145, 1567715668);
            int b2 = (1862276471);
            int2x3 r2 = int2x3(536871216, 134218752, 587202593, 1124078662, 687871057, 1291850068);
            TestUtils.AreEqual(a2 & b2, r2);

            int2x3 a3 = int2x3(1102952410, 1599352836, 208656708, 1272226025, 462670926, 1817145060);
            int b3 = (322053683);
            int2x3 r3 = int2x3(19932690, 319823872, 2228224, 51388449, 319947778, 140832);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1144543590);
            int2x3 b0 = int2x3(420346723, 562416448, 1393127318, 1560699552, 851218057, 703880958);
            int2x3 r0 = int2x3(547170, 18752, 1074284806, 1140867104, 3672064, 3168358);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1159378889);
            int2x3 b1 = int2x3(2031211279, 1089518981, 270607307, 1349288930, 520199596, 1763483957);
            int2x3 r1 = int2x3(1091605257, 1074836865, 9161, 1074299840, 83924360, 1092133121);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1248975349);
            int2x3 b2 = int2x3(236938635, 185023291, 1085233038, 1845693112, 946052961, 1436238522);
            int2x3 r2 = int2x3(168903041, 167844145, 1075925380, 1241581744, 140613985, 1074872496);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (2042776519);
            int2x3 b3 = int2x3(56356886, 1770159840, 1872339579, 1439201366, 1233066417, 1214109404);
            int2x3 r3 = int2x3(21118982, 1770146496, 1769996867, 1371555910, 1229064577, 1212170948);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_or_wide_wide()
        {
            int2x3 a0 = int2x3(1731159103, 659068416, 382702471, 1821032196, 1565773438, 1004000514);
            int2x3 b0 = int2x3(1583847161, 692672727, 1161585489, 1756207130, 1321374429, 1287357212);
            int2x3 r0 = int2x3(2138044159, 793370327, 1476391895, 1823457054, 1607720703, 2147473182);
            TestUtils.AreEqual(a0 | b0, r0);

            int2x3 a1 = int2x3(948501377, 600951835, 669346222, 396691477, 2108560248, 2117522137);
            int2x3 b1 = int2x3(2075767170, 1273513430, 1610830169, 1316929125, 511625048, 573925879);
            int2x3 r1 = int2x3(2075786115, 1811533279, 1743223295, 1610595957, 2147407736, 2117598207);
            TestUtils.AreEqual(a1 | b1, r1);

            int2x3 a2 = int2x3(330307355, 818676817, 1774459567, 1117506257, 1254511182, 1017865993);
            int2x3 b2 = int2x3(1502255628, 1841676448, 1682928938, 1115131952, 1541423910, 1416096228);
            int2x3 r2 = int2x3(1538957087, 2110637297, 1842315183, 1124063985, 1541821294, 2096099309);
            TestUtils.AreEqual(a2 | b2, r2);

            int2x3 a3 = int2x3(1883021644, 1140203470, 759288967, 2122744307, 335621148, 715028074);
            int2x3 b3 = int2x3(188606371, 1041599540, 219545389, 560097663, 1087543661, 936383841);
            int2x3 r3 = int2x3(2067654639, 2146934782, 760610735, 2145839615, 1423162749, 1071544171);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_or_wide_scalar()
        {
            int2x3 a0 = int2x3(961259683, 471103264, 1733389229, 1591585258, 386953869, 1148351449);
            int b0 = (1666102508);
            int2x3 r0 = int2x3(2068823279, 2136930284, 1734344685, 2145369582, 2002712301, 1736374269);
            TestUtils.AreEqual(a0 | b0, r0);

            int2x3 a1 = int2x3(1048929715, 860336789, 1637162093, 1227888278, 774029856, 879300408);
            int b1 = (1814263250);
            int2x3 r1 = int2x3(2124903923, 2137520087, 1840741887, 1832089558, 1847850994, 2087419898);
            TestUtils.AreEqual(a1 | b1, r1);

            int2x3 a2 = int2x3(1179087439, 1977614655, 46921989, 1980838747, 284225881, 64304104);
            int b2 = (797240690);
            int2x3 r2 = int2x3(1875378047, 2145709439, 802159991, 2140536699, 1073020283, 802553850);
            TestUtils.AreEqual(a2 | b2, r2);

            int2x3 a3 = int2x3(313591807, 1890090886, 521303722, 2021379070, 2055963359, 1511253082);
            int b3 = (1393862490);
            int2x3 r3 = int2x3(1404413951, 1941766110, 1595340794, 2071982078, 2074060767, 1528293210);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1213433101);
            int2x3 b0 = int2x3(1212928242, 1614462616, 936937728, 764766995, 306352095, 574719481);
            int2x3 r0 = int2x3(1213978111, 1752940445, 2145094925, 1842867999, 1515425759, 1783858685);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (1283571271);
            int2x3 b1 = int2x3(2109131012, 979469710, 1348323481, 1407542578, 697517649, 1059093741);
            int2x3 r1 = int2x3(2109210439, 2128723919, 1558052575, 1608908663, 1838415447, 2141322991);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (627815046);
            int2x3 b2 = int2x3(418822515, 83214352, 424663473, 447949225, 527022375, 1947148461);
            int2x3 r2 = int2x3(1040169975, 637530774, 1030749111, 1073462191, 1064024999, 1970254511);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (305251437);
            int2x3 b3 = int2x3(1254601325, 1752329425, 1592402684, 1587055329, 1088734150, 298563808);
            int2x3 r3 = int2x3(1526199917, 2054417661, 1593566973, 1589235437, 1391839215, 335281389);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_xor_wide_wide()
        {
            int2x3 a0 = int2x3(1556324760, 207002929, 1843444873, 1632079131, 1460334334, 1607815585);
            int2x3 b0 = int2x3(1054997548, 1523759632, 251164872, 110472397, 384031112, 1109163205);
            int2x3 r0 = int2x3(1646419380, 1451501345, 1662567489, 1741824470, 1105803126, 499723620);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2x3 a1 = int2x3(220623650, 38668553, 47193340, 643663548, 1371932564, 94957188);
            int2x3 b1 = int2x3(535118981, 179106262, 1523031711, 1713313372, 1294118730, 520360641);
            int2x3 r1 = int2x3(314783655, 149092575, 1477935715, 1078104288, 484747486, 447544389);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2x3 a2 = int2x3(700973621, 370621508, 2087573076, 351476570, 1340815927, 681577472);
            int2x3 b2 = int2x3(1040688781, 1020757245, 1143954843, 1281933464, 175288469, 326874157);
            int2x3 r2 = int2x3(399484088, 717273273, 943885263, 1486609346, 1167690402, 1004255277);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2x3 a3 = int2x3(314138777, 446857644, 1368661599, 1672499683, 1259759761, 2049102405);
            int2x3 b3 = int2x3(1192052687, 1087083643, 1900865484, 1521193463, 569695524, 1622101483);
            int2x3 r3 = int2x3(1437869910, 1516836311, 551090579, 958119956, 1793242549, 445489070);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_xor_wide_scalar()
        {
            int2x3 a0 = int2x3(2124666952, 177397845, 574879617, 1937385541, 1136545648, 213863690);
            int b0 = (493665894);
            int2x3 r0 = int2x3(1674536494, 402546227, 1060063719, 1846973987, 1590882582, 299103084);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2x3 a1 = int2x3(535061373, 1305234431, 353786540, 1308626970, 1267729267, 125659640);
            int b1 = (289301586);
            int2x3 r1 = int2x3(249169711, 1559375789, 69746430, 1597928520, 1521379105, 373493162);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2x3 a2 = int2x3(1315625690, 116862046, 375757978, 491079274, 191750702, 187129429);
            int b2 = (1730088797);
            int2x3 r2 = int2x3(695588231, 1642603267, 1903858631, 2052737335, 1819471219, 1815630088);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2x3 a3 = int2x3(967051293, 653124416, 788984, 1479174924, 1680011736, 447453839);
            int b3 = (549951551);
            int2x3 r3 = int2x3(425955362, 103447423, 550212039, 2028860211, 1155885543, 980157104);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1288453276);
            int2x3 b0 = int2x3(1077599928, 884741329, 212164516, 1585020328, 152985454, 1775851275);
            int2x3 r0 = int2x3(217506340, 2020616269, 1080648504, 313868596, 1171416050, 622160791);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1416249064);
            int2x3 b1 = int2x3(1309317737, 1773918217, 1509843030, 1206045972, 1154916424, 1947871003);
            int2x3 r1 = int2x3(442541185, 1037166305, 227827390, 327742460, 280796832, 544217587);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1774252400);
            int2x3 b2 = int2x3(1946113778, 1079717492, 290620937, 1382343363, 939045099, 1309568053);
            int2x3 r2 = int2x3(440379266, 698081028, 2022864761, 1000608691, 1580745115, 667852101);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (221134131);
            int2x3 b3 = int2x3(885841718, 612068188, 194068085, 1396957881, 573581481, 1813817520);
            int2x3 r3 = int2x3(971170309, 693458543, 113181510, 1584258954, 790500762, 1630705027);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_left_shift()
        {
            int2x3 a0 = int2x3(197771193, 622182602, 1283988958, 1327917304, 473415985, 432425717);
            int b0 = (1321149625);
            int2x3 r0 = int2x3(1912602624, -1811939328, -1140850688, -268435456, 1644167168, -369098752);
            TestUtils.AreEqual(a0 << b0, r0);

            int2x3 a1 = int2x3(870301196, 1200694230, 1531607705, 1360008038, 1008296534, 1447702302);
            int b1 = (2058433484);
            int2x3 r1 = int2x3(-69156864, 306012160, -1482059776, 20340736, -1775935488, -1561206784);
            TestUtils.AreEqual(a1 << b1, r1);

            int2x3 a2 = int2x3(1079614371, 1664454606, 2045594989, 2077023268, 592678686, 297755411);
            int b2 = (35667343);
            int2x3 r2 = int2x3(-841908224, -941162496, -1497989120, 1846673408, -946929664, -1316388864);
            TestUtils.AreEqual(a2 << b2, r2);

            int2x3 a3 = int2x3(1722762487, 37265945, 997793693, 1521705181, 263886278, 221147365);
            int b3 = (1161625759);
            int2x3 r3 = int2x3(-2147483648, -2147483648, -2147483648, -2147483648, 0, -2147483648);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_right_shift()
        {
            int2x3 a0 = int2x3(548167301, 1161338299, 1617625829, 1860731847, 713958715, 196552656);
            int b0 = (1266801540);
            int2x3 r0 = int2x3(34260456, 72583643, 101101614, 116295740, 44622419, 12284541);
            TestUtils.AreEqual(a0 >> b0, r0);

            int2x3 a1 = int2x3(770466193, 572763124, 506619530, 426807581, 2031319045, 701927980);
            int b1 = (1265099998);
            int2x3 r1 = int2x3(0, 0, 0, 0, 1, 0);
            TestUtils.AreEqual(a1 >> b1, r1);

            int2x3 a2 = int2x3(917785020, 185593382, 1102123711, 334005460, 1624751550, 280138733);
            int b2 = (569504877);
            int2x3 r2 = int2x3(112034, 22655, 134536, 40772, 198333, 34196);
            TestUtils.AreEqual(a2 >> b2, r2);

            int2x3 a3 = int2x3(1598620011, 736389149, 1279158873, 408822762, 763607760, 348013684);
            int b3 = (1840564178);
            int2x3 r3 = int2x3(6098, 2809, 4879, 1559, 2912, 1327);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void int2x3_operator_bitwise_not()
        {
            int2x3 a0 = int2x3(1403358969, 831360921, 2088190243, 976721016, 878283189, 308994339);
            int2x3 r0 = int2x3(-1403358970, -831360922, -2088190244, -976721017, -878283190, -308994340);
            TestUtils.AreEqual(~a0, r0);

            int2x3 a1 = int2x3(1935567517, 472965491, 771711426, 627580960, 2061524024, 753208488);
            int2x3 r1 = int2x3(-1935567518, -472965492, -771711427, -627580961, -2061524025, -753208489);
            TestUtils.AreEqual(~a1, r1);

            int2x3 a2 = int2x3(2097179283, 664744603, 1289372466, 1635981125, 1951018596, 1545651937);
            int2x3 r2 = int2x3(-2097179284, -664744604, -1289372467, -1635981126, -1951018597, -1545651938);
            TestUtils.AreEqual(~a2, r2);

            int2x3 a3 = int2x3(717936457, 1342785385, 869629475, 2045854321, 1282546942, 1562433528);
            int2x3 r3 = int2x3(-717936458, -1342785386, -869629476, -2045854322, -1282546943, -1562433529);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
