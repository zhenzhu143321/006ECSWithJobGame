// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4x2
    {
        [TestCompiler]
        public static void float4x2_zero()
        {
            TestUtils.AreEqual(float4x2.zero.c0.x, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c0.y, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c0.z, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c0.w, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c1.x, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c1.y, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c1.z, 0.0f);
            TestUtils.AreEqual(float4x2.zero.c1.w, 0.0f);
        }

        [TestCompiler]
        public static void float4x2_operator_equal_wide_wide()
        {
            float4x2 a0 = float4x2(-135.18924f, -49.0941162f, 169.129822f, 240.8053f, 314.7392f, 442.393f, 177.924438f, 335.5334f);
            float4x2 b0 = float4x2(-220.014648f, 66.98004f, 499.2016f, -371.1131f, 208.448669f, 390.8037f, -72.44382f, 362.97644f);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x2 a1 = float4x2(168.15448f, 350.729553f, 367.178467f, 46.9414673f, 188.76416f, -97.2113953f, -293.320984f, -234.822937f);
            float4x2 b1 = float4x2(194.678345f, 471.644836f, -404.044678f, -144.696747f, -494.446655f, -252.970367f, 234.417114f, 398.724f);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x2 a2 = float4x2(417.0337f, 26.3864136f, 269.245728f, 29.4741821f, 479.485229f, -237.230957f, -221.9837f, -506.672546f);
            float4x2 b2 = float4x2(260.4287f, 370.144226f, 89.579834f, -434.816833f, -109.845337f, 336.973022f, -409.154968f, 500.387573f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x2 a3 = float4x2(-22.98944f, 487.260864f, -419.731964f, 337.2033f, 245.043884f, 390.215881f, 84.4129639f, 434.2079f);
            float4x2 b3 = float4x2(-174.081818f, 395.101135f, 350.3393f, -243.144592f, -416.397369f, 151.576477f, -18.2243347f, -431.677917f);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_equal_wide_scalar()
        {
            float4x2 a0 = float4x2(65.6712f, 404.415527f, -269.730164f, 83.6306152f, 152.9945f, -155.868286f, 314.671265f, 386.365173f);
            float b0 = (-155.815765f);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x2 a1 = float4x2(290.04895f, -65.66748f, -69.68326f, -191.190765f, 186.845215f, -232.895691f, -319.144043f, -49.70108f);
            float b1 = (-132.6352f);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x2 a2 = float4x2(-300.8819f, 386.3775f, -296.7019f, -309.1172f, 141.542358f, -227.323334f, 83.87286f, -410.91687f);
            float b2 = (333.396851f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x2 a3 = float4x2(110.501282f, 36.57434f, -427.541443f, -268.170837f, 175.8117f, -193.47995f, 291.051941f, 423.97168f);
            float b3 = (-390.103577f);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float4x2 b0 = float4x2(-400.4892f, -71.2868347f, 156.978088f, -225.238739f, 499.141785f, -211.979919f, 428.311951f, -489.501343f);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-5.691559f);
            float4x2 b1 = float4x2(-30.8659363f, -362.9831f, 184.503174f, -160.470612f, 316.668823f, 390.369263f, 505.1051f, -294.6487f);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (443.1991f);
            float4x2 b2 = float4x2(96.5592651f, -257.012939f, -245.054962f, 326.464844f, -23.9599f, -168.694885f, 386.2486f, -227.090637f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-336.612427f);
            float4x2 b3 = float4x2(365.108154f, -405.390839f, -473.995483f, 298.435364f, -149.86322f, 450.0664f, 153.47644f, 56.28778f);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_not_equal_wide_wide()
        {
            float4x2 a0 = float4x2(279.994141f, -43.34201f, -465.724731f, 317.466553f, 85.7149658f, 360.8905f, 366.081543f, 154.542847f);
            float4x2 b0 = float4x2(-460.9121f, -476.009033f, 468.1364f, -341.012543f, -62.65805f, -458.801666f, -457.730225f, -59.5232544f);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x2 a1 = float4x2(332.4262f, 397.11322f, -431.374969f, 489.0108f, 398.4336f, -489.817932f, 171.4049f, -67.82968f);
            float4x2 b1 = float4x2(3.024231f, 155.812744f, -19.8399048f, -6.01693726f, -406.207916f, -102.420715f, -40.362915f, 452.6754f);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x2 a2 = float4x2(-192.278717f, 227.84082f, 62.1381836f, 262.186462f, -404.0531f, 34.449585f, -204.795776f, -285.4118f);
            float4x2 b2 = float4x2(93.25757f, -258.378052f, -184.0498f, -379.2353f, -370.687317f, -255.947235f, 29.0557861f, 322.407654f);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x2 a3 = float4x2(-72.20682f, 444.749268f, 238.81781f, 365.1801f, -437.9229f, -362.442627f, 445.954346f, -0.417480469f);
            float4x2 b3 = float4x2(415.071716f, -467.726135f, -433.784668f, -212.165924f, 474.674927f, 452.483215f, -92.11273f, -385.9221f);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_not_equal_wide_scalar()
        {
            float4x2 a0 = float4x2(-155.4411f, -19.4266052f, 174.633057f, 507.920715f, 59.177063f, 171.151489f, -58.92328f, -398.176849f);
            float b0 = (-393.413544f);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x2 a1 = float4x2(492.20105f, 270.341f, -380.243256f, 501.899048f, -134.345459f, 458.400452f, 46.7709961f, 161.459961f);
            float b1 = (-165.241516f);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x2 a2 = float4x2(261.514221f, -0.449920654f, 350.461426f, 202.221008f, 242.664f, 382.677063f, -468.967957f, -497.459473f);
            float b2 = (-145.6124f);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x2 a3 = float4x2(-80.93225f, -506.490326f, 449.348145f, 210.771f, 249.181824f, -338.468536f, 229.670654f, -76.5433044f);
            float b3 = (-328.587769f);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float4x2 b0 = float4x2(459.553223f, 436.453247f, -488.714172f, 392.767944f, -266.736633f, 338.557861f, -338.100128f, -152.314545f);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-452.820679f);
            float4x2 b1 = float4x2(209.439331f, 50.10797f, 372.4344f, -488.0213f, 489.740784f, 270.4001f, -472.846771f, -286.850464f);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-384.691864f);
            float4x2 b2 = float4x2(443.423523f, 358.7472f, -15.4140625f, -342.179169f, 468.967529f, -130.568085f, 401.785828f, -268.352264f);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-239.231018f);
            float4x2 b3 = float4x2(411.386536f, 139.769348f, 334.522034f, -223.629242f, -12.4884644f, 113.468872f, -189.652252f, -212.846558f);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_less_wide_wide()
        {
            float4x2 a0 = float4x2(51.7102661f, -313.85556f, 283.047668f, 235.021912f, 44.07837f, -207.255676f, 3.38293457f, -144.301331f);
            float4x2 b0 = float4x2(-261.835236f, -19.81073f, -149.25882f, 205.99823f, -306.024384f, 102.121704f, 231.906311f, 179.49884f);
            bool4x2 r0 = bool4x2(false, true, false, false, false, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x2 a1 = float4x2(-69.3696f, -135.667969f, -194.787354f, -33.473877f, -19.67508f, 423.237976f, -71.6983f, -501.886f);
            float4x2 b1 = float4x2(473.2249f, 15.8916626f, 270.049927f, 490.914f, -185.734131f, 76.4331055f, 97.75232f, 419.300781f);
            bool4x2 r1 = bool4x2(true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x2 a2 = float4x2(7.64386f, 302.262878f, -140.5505f, -436.5867f, -351.4417f, 364.970825f, 301.8941f, 407.550964f);
            float4x2 b2 = float4x2(73.953186f, 481.032349f, 7.00744629f, -7.32409668f, -413.075745f, -154.1189f, 449.202881f, 502.014282f);
            bool4x2 r2 = bool4x2(true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x2 a3 = float4x2(269.1078f, 462.98822f, 223.884155f, -287.18924f, 283.6386f, 511.864319f, -60.4967957f, -234.303467f);
            float4x2 b3 = float4x2(-382.315857f, 251.535156f, 143.17395f, 293.660339f, -292.769562f, -43.2182f, -353.4112f, 458.32605f);
            bool4x2 r3 = bool4x2(false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_less_wide_scalar()
        {
            float4x2 a0 = float4x2(-221.869781f, -121.546478f, -97.5239258f, 479.8811f, 67.11902f, 137.3288f, 282.9666f, 258.2791f);
            float b0 = (199.0675f);
            bool4x2 r0 = bool4x2(true, true, true, false, true, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x2 a1 = float4x2(-111.413147f, 82.6654053f, -361.6429f, -68.0881958f, 12.7880249f, -66.703064f, -78.76297f, 25.7277222f);
            float b1 = (-288.081116f);
            bool4x2 r1 = bool4x2(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x2 a2 = float4x2(101.37085f, -48.9205322f, 359.604431f, -8.150085f, 241.2768f, -183.437775f, 423.027161f, -334.622742f);
            float b2 = (-330.442657f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x2 a3 = float4x2(-98.31558f, 297.925232f, -492.108154f, -395.807251f, 95.78882f, -220.62146f, -455.37558f, 360.291565f);
            float b3 = (300.410156f);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float4x2 b0 = float4x2(-377.196533f, -505.147552f, 375.9267f, 110.17395f, -118.097565f, -40.4508972f, -299.744324f, 31.4371338f);
            bool4x2 r0 = bool4x2(false, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-458.904541f);
            float4x2 b1 = float4x2(13.6846924f, -458.5069f, 248.276489f, 389.231445f, 488.745544f, -221.637878f, -424.2672f, 249.059021f);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-22.1361389f);
            float4x2 b2 = float4x2(-442.247742f, -340.857544f, -95.1117249f, 15.4094238f, 87.29248f, 495.067627f, 316.0185f, -125.568115f);
            bool4x2 r2 = bool4x2(false, false, false, true, true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (122.164795f);
            float4x2 b3 = float4x2(96.75537f, -228.906342f, -143.9527f, -230.238281f, -327.6126f, 103.39801f, 434.488831f, -157.4502f);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_greater_wide_wide()
        {
            float4x2 a0 = float4x2(-229.29068f, 505.536621f, -73.80707f, 100.292053f, -419.214783f, -159.559753f, -396.770355f, 127.037415f);
            float4x2 b0 = float4x2(-445.845032f, -420.035278f, 299.0244f, -13.8809814f, 151.5617f, -163.50943f, -391.096039f, 479.283752f);
            bool4x2 r0 = bool4x2(true, true, false, true, false, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x2 a1 = float4x2(489.1399f, 51.9188843f, 155.384766f, -135.631653f, -425.978149f, -228.430511f, 383.03833f, 136.533569f);
            float4x2 b1 = float4x2(-77.6748657f, -46.584198f, -415.377f, 71.46698f, -206.061035f, 360.8363f, 236.968811f, 14.550354f);
            bool4x2 r1 = bool4x2(true, true, true, false, false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x2 a2 = float4x2(8.602417f, -251.324371f, -345.954926f, -170.565918f, -293.2544f, 139.125f, 214.3031f, 238.7699f);
            float4x2 b2 = float4x2(364.735168f, -159.06131f, 226.631165f, 182.796021f, 341.839355f, -79.13046f, -247.296814f, 164.589111f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x2 a3 = float4x2(105.535217f, -170.9253f, 26.9802246f, -188.928314f, 201.786621f, -506.057159f, 15.454895f, 115.080688f);
            float4x2 b3 = float4x2(-352.1598f, 9.822632f, 186.721619f, -325.913635f, -77.93036f, -379.746033f, 251.45575f, -144.183563f);
            bool4x2 r3 = bool4x2(true, false, false, true, true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_greater_wide_scalar()
        {
            float4x2 a0 = float4x2(11.156311f, -411.023224f, 385.885559f, -485.103058f, -491.180023f, 405.175354f, 173.575073f, 69.26929f);
            float b0 = (-302.816956f);
            bool4x2 r0 = bool4x2(true, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x2 a1 = float4x2(501.306824f, -86.12451f, -489.090576f, -172.518158f, -18.1496277f, -236.414948f, -238.8945f, -27.2391357f);
            float b1 = (-367.027771f);
            bool4x2 r1 = bool4x2(true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x2 a2 = float4x2(471.779358f, -481.4781f, 185.59436f, 33.29474f, -510.228149f, -183.2862f, -386.127655f, -13.6382141f);
            float b2 = (240.164551f);
            bool4x2 r2 = bool4x2(true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x2 a3 = float4x2(-7.34790039f, 52.24951f, 16.3232422f, -410.5101f, -262.2675f, -458.255981f, -218.866119f, -34.6923523f);
            float b3 = (-261.865967f);
            bool4x2 r3 = bool4x2(true, true, true, false, false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float4x2 b0 = float4x2(-226.2044f, -423.465f, 409.405518f, 453.877075f, 87.47571f, 113.795593f, 176.409241f, -140.440033f);
            bool4x2 r0 = bool4x2(true, true, true, false, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (-182.48288f);
            float4x2 b1 = float4x2(-158.2933f, -162.685333f, -193.328674f, 230.181274f, -102.58783f, 392.520569f, -177.478668f, -10.2950134f);
            bool4x2 r1 = bool4x2(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-24.04895f);
            float4x2 b2 = float4x2(172.448669f, 374.048035f, -368.99762f, -210.195282f, 149.470215f, -281.343262f, -100.469177f, 304.864441f);
            bool4x2 r2 = bool4x2(false, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-361.524841f);
            float4x2 b3 = float4x2(-372.452362f, -33.9095459f, -69.5952759f, -460.4324f, -309.341675f, 486.131531f, 471.920959f, 479.361572f);
            bool4x2 r3 = bool4x2(true, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_less_equal_wide_wide()
        {
            float4x2 a0 = float4x2(240.090515f, 462.213135f, 293.08252f, -427.870667f, -405.5227f, 204.591919f, 294.6701f, -327.564453f);
            float4x2 b0 = float4x2(-81.20383f, 493.637451f, -411.4721f, 99.16443f, -295.6677f, -480.462555f, 74.41406f, 260.916138f);
            bool4x2 r0 = bool4x2(false, true, false, true, true, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x2 a1 = float4x2(-456.12326f, 282.30127f, 421.881165f, -311.71283f, 84.5675049f, 447.244629f, -154.494354f, -424.364746f);
            float4x2 b1 = float4x2(306.173279f, 139.564819f, -505.752472f, -489.6268f, -280.0326f, 303.1599f, 511.1902f, -104.659729f);
            bool4x2 r1 = bool4x2(true, false, false, false, false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x2 a2 = float4x2(36.68451f, 267.0703f, 307.893921f, -351.760132f, -157.360352f, 152.709045f, 372.267151f, 202.368286f);
            float4x2 b2 = float4x2(95.14661f, -125.636353f, 376.2398f, -415.774719f, -47.48105f, 117.722107f, 469.378357f, -263.042358f);
            bool4x2 r2 = bool4x2(true, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x2 a3 = float4x2(-77.04346f, 438.1848f, 260.282349f, 386.034058f, -281.491f, -102.930054f, -346.716736f, -258.3412f);
            float4x2 b3 = float4x2(-216.002319f, 66.73425f, 99.21863f, 233.843018f, 439.839966f, 61.1151123f, -219.030579f, -404.7129f);
            bool4x2 r3 = bool4x2(false, false, false, false, true, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_less_equal_wide_scalar()
        {
            float4x2 a0 = float4x2(309.192444f, 69.67377f, -101.724182f, -315.9724f, -346.011047f, 424.15387f, -410.870056f, -483.902649f);
            float b0 = (292.924255f);
            bool4x2 r0 = bool4x2(false, true, true, true, true, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x2 a1 = float4x2(183.821167f, -257.870056f, -386.801758f, -182.938812f, 349.250122f, 485.311584f, 373.5691f, 259.1515f);
            float b1 = (320.4425f);
            bool4x2 r1 = bool4x2(true, true, true, true, false, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x2 a2 = float4x2(450.130066f, -43.8748779f, 457.385742f, -77.6383057f, 479.451843f, -499.516449f, -398.132935f, 402.484863f);
            float b2 = (-128.525543f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x2 a3 = float4x2(87.91608f, 125.950806f, -54.49362f, 250.667419f, 97.94293f, 228.021545f, -213.378662f, 42.2608032f);
            float b3 = (-502.1736f);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float4x2 b0 = float4x2(51.1589966f, 340.443665f, 312.81427f, 354.1925f, 136.396729f, -94.76788f, 288.5443f, 304.042847f);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-148.618073f);
            float4x2 b1 = float4x2(-506.3001f, 27.5812378f, 48.47113f, 104.883484f, -488.685852f, -480.435181f, 421.936646f, 239.721069f);
            bool4x2 r1 = bool4x2(false, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-101.018433f);
            float4x2 b2 = float4x2(-283.951477f, -55.24353f, -455.80484f, 131.107239f, -461.6988f, -388.482849f, -258.936035f, -225.223541f);
            bool4x2 r2 = bool4x2(false, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-116.019989f);
            float4x2 b3 = float4x2(-442.595245f, 297.333374f, 36.6872559f, 485.097839f, 344.445679f, 237.592163f, 230.390869f, -413.9848f);
            bool4x2 r3 = bool4x2(false, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_greater_equal_wide_wide()
        {
            float4x2 a0 = float4x2(-386.5918f, -157.120789f, 391.015259f, -511.886871f, -5.42202759f, 287.645264f, -122.535187f, 7.48144531f);
            float4x2 b0 = float4x2(153.443f, 49.8924561f, 78.02582f, 138.813721f, -225.51059f, -339.3561f, -373.302063f, 364.9359f);
            bool4x2 r0 = bool4x2(false, false, true, false, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x2 a1 = float4x2(152.946411f, 48.9862061f, 57.3381348f, 300.4649f, 349.25708f, 85.7496948f, -230.953308f, 418.711243f);
            float4x2 b1 = float4x2(-322.7154f, 125.47821f, -25.77658f, 297.518921f, 73.22235f, 462.783752f, 393.191345f, -95.0014343f);
            bool4x2 r1 = bool4x2(true, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x2 a2 = float4x2(-131.039917f, -126.512207f, -156.818481f, 422.3775f, -413.089325f, 219.442749f, 35.5911255f, 447.181519f);
            float4x2 b2 = float4x2(381.357056f, 93.03192f, 254.253235f, 90.67279f, 348.938171f, 161.337646f, 79.43561f, 420.243469f);
            bool4x2 r2 = bool4x2(false, false, false, true, false, true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x2 a3 = float4x2(-223.492981f, 302.123f, 459.852722f, -347.128021f, 364.9781f, 212.635437f, 504.276062f, -142.232971f);
            float4x2 b3 = float4x2(453.684875f, -154.011658f, -97.29007f, 151.184753f, 57.36029f, -194.207092f, -462.670624f, 113.3866f);
            bool4x2 r3 = bool4x2(false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_greater_equal_wide_scalar()
        {
            float4x2 a0 = float4x2(495.4574f, -14.3451233f, -463.4748f, 217.517517f, -246.865723f, -377.6587f, 53.8151245f, -123.332947f);
            float b0 = (189.205139f);
            bool4x2 r0 = bool4x2(true, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x2 a1 = float4x2(-221.505463f, -116.440369f, -395.3633f, 164.772583f, -287.007324f, 355.837036f, 184.195557f, 273.012268f);
            float b1 = (252.994324f);
            bool4x2 r1 = bool4x2(false, false, false, false, false, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x2 a2 = float4x2(-418.1424f, 396.392151f, 332.6654f, 243.761414f, -335.12146f, -302.0869f, 254.442261f, 179.005066f);
            float b2 = (249.3841f);
            bool4x2 r2 = bool4x2(false, true, true, false, false, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x2 a3 = float4x2(71.1767f, 307.890564f, -388.578522f, 150.605774f, -219.892578f, -491.681f, 30.99707f, 199.232239f);
            float b3 = (-331.271667f);
            bool4x2 r3 = bool4x2(true, true, false, true, true, false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float4x2 b0 = float4x2(204.802979f, -101.104034f, -122.055023f, -70.45615f, -239.62027f, -185.992737f, -455.612579f, 276.665833f);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (79.39917f);
            float4x2 b1 = float4x2(416.420532f, 379.2735f, -439.5147f, 67.14099f, -74.56064f, -367.256348f, 494.950745f, -61.2355347f);
            bool4x2 r1 = bool4x2(false, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-429.170258f);
            float4x2 b2 = float4x2(-213.824677f, -264.310181f, 243.11377f, -22.38388f, 304.862f, -323.686157f, 67.93805f, 125.303589f);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-400.47052f);
            float4x2 b3 = float4x2(-283.159637f, -42.31961f, -429.510376f, 499.395874f, -289.963074f, -136.008789f, -351.125244f, -381.8183f);
            bool4x2 r3 = bool4x2(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_add_wide_wide()
        {
            float4x2 a0 = float4x2(465.148376f, 278.9107f, -277.5299f, -65.1972046f, -473.324371f, -4.69555664f, -470.536774f, -109.9501f);
            float4x2 b0 = float4x2(483.9944f, -204.07666f, -365.673553f, -509.920868f, -270.6975f, 486.763977f, 267.49176f, 251.642517f);
            float4x2 r0 = float4x2(949.142761f, 74.8340454f, -643.2035f, -575.118042f, -744.021851f, 482.06842f, -203.045013f, 141.692413f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x2 a1 = float4x2(-178.701447f, -420.033783f, 290.711121f, -446.529633f, 491.066467f, -261.1173f, -298.4069f, 502.4286f);
            float4x2 b1 = float4x2(244.495117f, -78.67575f, 352.2055f, 82.7791748f, 462.5473f, -405.492f, -428.498322f, -41.87259f);
            float4x2 r1 = float4x2(65.79367f, -498.709534f, 642.9166f, -363.750458f, 953.6138f, -666.6093f, -726.9052f, 460.556f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x2 a2 = float4x2(284.5943f, 401.128418f, -36.26349f, -102.949158f, 503.198181f, -384.4291f, -45.22821f, -198.67395f);
            float4x2 b2 = float4x2(-269.9275f, 75.20447f, -141.913391f, -222.186768f, 41.3057251f, 148.339478f, -177.233124f, -176.51889f);
            float4x2 r2 = float4x2(14.6668091f, 476.3329f, -178.17688f, -325.135925f, 544.5039f, -236.08963f, -222.461334f, -375.192841f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x2 a3 = float4x2(-62.8800049f, -79.5522461f, 413.098267f, -100.877594f, 418.524f, -183.143127f, 407.443726f, 300.486023f);
            float4x2 b3 = float4x2(492.692444f, 439.043823f, -511.742767f, -399.057129f, -315.868469f, -228.07724f, -171.7052f, 467.17395f);
            float4x2 r3 = float4x2(429.812439f, 359.491577f, -98.6445f, -499.934723f, 102.655518f, -411.220367f, 235.738525f, 767.66f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_add_wide_scalar()
        {
            float4x2 a0 = float4x2(459.898315f, -447.663361f, -94.43863f, 126.429871f, -36.254364f, -349.6413f, -2.79125977f, -478.4148f);
            float b0 = (500.997253f);
            float4x2 r0 = float4x2(960.895569f, 53.3338928f, 406.558624f, 627.4271f, 464.7429f, 151.355957f, 498.206f, 22.5824585f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x2 a1 = float4x2(443.115234f, 41.3210449f, -471.256073f, -2.664978f, 78.98584f, 202.14801f, 311.725464f, 10.3458252f);
            float b1 = (268.092224f);
            float4x2 r1 = float4x2(711.207458f, 309.413269f, -203.163849f, 265.427246f, 347.078064f, 470.240234f, 579.8177f, 278.438049f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x2 a2 = float4x2(-151.244446f, -197.800751f, 255.955261f, 244.1471f, -181.626556f, -2.45492554f, 300.900635f, -236.491943f);
            float b2 = (355.2328f);
            float4x2 r2 = float4x2(203.988342f, 157.432037f, 611.188049f, 599.3799f, 173.606232f, 352.777863f, 656.1334f, 118.740845f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x2 a3 = float4x2(-160.5841f, -242.9411f, 466.344116f, 237.987488f, 264.294f, 372.866821f, -198.837769f, -381.930969f);
            float b3 = (-172.5422f);
            float4x2 r3 = float4x2(-333.1263f, -415.4833f, 293.8019f, 65.44528f, 91.7518f, 200.324615f, -371.379974f, -554.473145f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float4x2 b0 = float4x2(-264.088135f, -106.009247f, -355.4473f, -447.3303f, -158.7002f, -199.4837f, 180.318115f, 337.579346f);
            float4x2 r0 = float4x2(-589.6009f, -431.522f, -680.9601f, -772.843f, -484.212952f, -524.99646f, -145.194641f, 12.0665894f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-37.0550232f);
            float4x2 b1 = float4x2(230.805f, -140.174347f, 18.02417f, -138.614349f, 26.9041748f, -374.5376f, 154.46759f, 268.38385f);
            float4x2 r1 = float4x2(193.749969f, -177.22937f, -19.0308533f, -175.669373f, -10.1508484f, -411.592621f, 117.412567f, 231.328827f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-190.963013f);
            float4x2 b2 = float4x2(188.617249f, -504.916138f, 20.45404f, 197.945374f, 251.411926f, -421.0904f, 111.445374f, -73.26889f);
            float4x2 r2 = float4x2(-2.34576416f, -695.87915f, -170.508972f, 6.982361f, 60.4489136f, -612.0534f, -79.51764f, -264.2319f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (480.884583f);
            float4x2 b3 = float4x2(438.05304f, 66.8443f, -270.796021f, -44.02191f, 197.6947f, 19.1139526f, 349.2378f, 366.2345f);
            float4x2 r3 = float4x2(918.9376f, 547.7289f, 210.088562f, 436.862671f, 678.5793f, 499.998535f, 830.1224f, 847.1191f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_sub_wide_wide()
        {
            float4x2 a0 = float4x2(133.371033f, -131.832123f, -197.293152f, -485.28656f, -337.550323f, 471.6671f, 146.506592f, -130.585052f);
            float4x2 b0 = float4x2(123.460266f, 359.56012f, -48.2484741f, 478.979065f, 207.158325f, 142.36731f, -125.6055f, -65.29901f);
            float4x2 r0 = float4x2(9.910767f, -491.392242f, -149.044678f, -964.2656f, -544.7086f, 329.2998f, 272.1121f, -65.28604f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x2 a1 = float4x2(110.7771f, -235.5416f, 78.87933f, -347.686157f, -470.820557f, -11.45929f, -167.9479f, 330.676758f);
            float4x2 b1 = float4x2(-477.876434f, 164.5f, 428.009583f, 72.62781f, -446.8805f, 432.091431f, -225.554657f, -112.451965f);
            float4x2 r1 = float4x2(588.653564f, -400.0416f, -349.130249f, -420.313965f, -23.9400635f, -443.55072f, 57.60675f, 443.128723f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x2 a2 = float4x2(-508.350861f, -252.031891f, -427.9342f, 192.6576f, 168.429321f, 457.308777f, 470.058533f, -299.711884f);
            float4x2 b2 = float4x2(-210.6128f, -172.925049f, -80.60748f, 270.046082f, -154.255585f, 148.475769f, 13.6611328f, 70.67108f);
            float4x2 r2 = float4x2(-297.738068f, -79.10684f, -347.326721f, -77.38849f, 322.6849f, 308.833f, 456.3974f, -370.382965f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x2 a3 = float4x2(-308.939575f, 454.5334f, 26.1069336f, -482.711823f, -40.8535461f, 318.380676f, 475.210815f, 134.926941f);
            float4x2 b3 = float4x2(-221.325439f, -9.25882f, 288.173828f, 217.36145f, 307.540039f, -262.412659f, -405.378021f, 400.004333f);
            float4x2 r3 = float4x2(-87.6141357f, 463.7922f, -262.0669f, -700.073242f, -348.3936f, 580.793335f, 880.588867f, -265.0774f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_sub_wide_scalar()
        {
            float4x2 a0 = float4x2(48.9367065f, 410.4516f, -364.4417f, 163.980591f, -460.067322f, 110.919434f, 204.358337f, 180.269714f);
            float b0 = (-291.5904f);
            float4x2 r0 = float4x2(340.5271f, 702.042f, -72.85132f, 455.570984f, -168.476929f, 402.509827f, 495.94873f, 471.8601f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x2 a1 = float4x2(-377.9257f, 400.5349f, 461.507568f, -246.287262f, 21.6052856f, 246.350708f, -121.427368f, -122.718414f);
            float b1 = (-470.262054f);
            float4x2 r1 = float4x2(92.3363647f, 870.797f, 931.769653f, 223.9748f, 491.86734f, 716.6128f, 348.8347f, 347.54364f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x2 a2 = float4x2(-122.938721f, 342.874573f, 18.92981f, 164.602356f, 97.0437f, 485.914978f, -205.75766f, 253.443237f);
            float b2 = (360.15094f);
            float4x2 r2 = float4x2(-483.089661f, -17.2763672f, -341.22113f, -195.548584f, -263.107239f, 125.764038f, -565.908569f, -106.7077f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x2 a3 = float4x2(-121.163055f, -450.820282f, -248.073364f, -26.9960632f, 441.5526f, 449.910583f, 354.886047f, 98.82147f);
            float b3 = (187.998413f);
            float4x2 r3 = float4x2(-309.161469f, -638.8187f, -436.071777f, -214.994476f, 253.5542f, 261.91217f, 166.887634f, -89.17694f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float4x2 b0 = float4x2(452.352539f, 256.9898f, -275.159882f, -89.02753f, 488.2284f, -333.2173f, -64.233f, -66.04172f);
            float4x2 r0 = float4x2(-157.766052f, 37.59668f, 569.746338f, 383.614f, -193.6419f, 627.8038f, 358.8195f, 360.6282f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (341.204956f);
            float4x2 b1 = float4x2(-385.775055f, 75.3947754f, 354.943726f, 169.131409f, 88.21661f, 1.73498535f, 122.538025f, -264.945f);
            float4x2 r1 = float4x2(726.98f, 265.810181f, -13.73877f, 172.073547f, 252.988342f, 339.469971f, 218.666931f, 606.149963f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-50.83719f);
            float4x2 b2 = float4x2(-347.65033f, 4.06555176f, -79.09543f, 354.358337f, -292.4925f, -53.2089844f, -246.3476f, 299.203369f);
            float4x2 r2 = float4x2(296.813141f, -54.90274f, 28.25824f, -405.195526f, 241.6553f, 2.37179565f, 195.5104f, -350.040558f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (432.1847f);
            float4x2 b3 = float4x2(-163.88f, 176.742554f, -104.98584f, -445.797638f, -28.8731689f, -169.588226f, -270.359253f, 68.04761f);
            float4x2 r3 = float4x2(596.0647f, 255.442139f, 537.170532f, 877.9823f, 461.057861f, 601.772949f, 702.543945f, 364.1371f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_mul_wide_wide()
        {
            float4x2 a0 = float4x2(-394.780548f, -412.3722f, -25.8745728f, -241.045959f, -93.6759949f, 244.159973f, 494.688477f, 53.5379639f);
            float4x2 b0 = float4x2(-149.763977f, -345.04538f, -284.334045f, 267.979248f, -326.6485f, -150.689667f, 207.732422f, 366.192871f);
            float4x2 r0 = float4x2(59123.9063f, 142287.125f, 7357.022f, -64595.3164f, 30599.123f, -36792.3867f, 102762.836f, 19605.22f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x2 a1 = float4x2(-239.4964f, 236.675842f, -211.8562f, -216.654816f, 467.9583f, -178.021912f, -386.394257f, -422.4354f);
            float4x2 b1 = float4x2(358.880737f, 214.853577f, 253.422791f, -307.7138f, 184.47113f, 426.436462f, -144.281433f, 459.4796f);
            float4x2 r1 = float4x2(-85950.64f, 50850.6523f, -53689.19f, 66667.68f, 86324.8f, -75915.03f, 55749.5156f, -194100.453f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x2 a2 = float4x2(464.589539f, -251.315674f, -104.97879f, -66.93417f, -39.829895f, 401.5656f, 434.146179f, -336.4542f);
            float4x2 b2 = float4x2(-358.313354f, -201.3652f, 254.909973f, 168.520935f, 8.794556f, -194.846466f, -405.362671f, -180.732178f);
            float4x2 r2 = float4x2(-166468.641f, 50606.23f, -26760.14f, -11279.81f, -350.286224f, -78243.64f, -175986.656f, 60808.0977f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x2 a3 = float4x2(-83.11417f, 329.960266f, -316.972168f, 474.937927f, -445.109161f, -301.003723f, 405.687866f, 142.373474f);
            float4x2 b3 = float4x2(-189.746918f, -35.5184631f, 120.31665f, -136.203339f, 407.3416f, 301.6543f, -155.482391f, -461.394562f);
            float4x2 r3 = float4x2(15770.6572f, -11719.6816f, -38137.03f, -64688.1328f, -181311.484f, -90799.07f, -63077.32f, -65690.34f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_mul_wide_scalar()
        {
            float4x2 a0 = float4x2(328.203f, -290.10672f, 236.995728f, 120.481384f, 357.903137f, 134.867249f, -477.3105f, -438.272919f);
            float b0 = (192.211182f);
            float4x2 r0 = float4x2(63084.2852f, -55761.7539f, 45553.23f, 23157.87f, 68792.9844f, 25922.9941f, -91744.4141f, -84240.95f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x2 a1 = float4x2(-46.729187f, 422.08252f, -48.83484f, 355.30835f, 119.356628f, -196.995819f, 98.23602f, -325.552155f);
            float b1 = (-238.405f);
            float4x2 r1 = float4x2(11140.4717f, -100626.586f, 11642.47f, -84707.29f, -28455.2168f, 46964.79f, -23419.959f, 77613.26f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x2 a2 = float4x2(53.9373169f, -130.474121f, -222.594574f, 126.015015f, 293.361084f, 174.381958f, -327.120056f, 56.62915f);
            float b2 = (-87.45099f);
            float4x2 r2 = float4x2(-4716.87158f, 11410.0908f, 19466.1152f, -11020.1377f, -25654.7168f, -15249.875f, 28606.9727f, -4952.27539f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x2 a3 = float4x2(257.541565f, -452.6919f, -49.22061f, 141.600952f, 431.5857f, 180.355164f, -40.9234619f, 279.543518f);
            float b3 = (-475.6087f);
            float4x2 r3 = float4x2(-122489.008f, 215304.2f, 23409.752f, -67346.65f, -205265.9f, -85778.4844f, 19463.5547f, -132953.328f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float4x2 b0 = float4x2(329.360962f, -198.683441f, 184.0794f, 256.016174f, 266.226318f, -97.8947449f, 159.748108f, -351.8222f);
            float4x2 r0 = float4x2(-152999.6f, 92295.35f, -85511.27f, -118928.4f, -123671.359f, 45475.5039f, -74208.54f, 163433.625f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (491.801575f);
            float4x2 b1 = float4x2(49.90204f, 424.4626f, 160.1181f, -395.9921f, 125.20166f, -265.0158f, 314.656128f, -292.712036f);
            float4x2 r1 = float4x2(24541.9f, 208751.375f, 78746.3359f, -194749.531f, 61574.375f, -130335.195f, 154748.375f, -143956.234f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-37.72989f);
            float4x2 b2 = float4x2(165.362244f, 356.517761f, -188.813324f, 504.9157f, 40.5721436f, -206.775116f, -61.60269f, 118.971619f);
            float4x2 r2 = float4x2(-6239.099f, -13451.376f, 7123.906f, -19050.4141f, -1530.78247f, 7801.602f, 2324.2627f, -4488.786f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (53.7483521f);
            float4x2 b3 = float4x2(-198.6694f, 96.236084f, -20.2418823f, -31.1239624f, 38.89044f, -13.1333008f, 507.871277f, 95.0179443f);
            float4x2 r3 = float4x2(-10678.1533f, 5172.531f, -1087.96777f, -1672.86169f, 2090.297f, -705.89325f, 27297.2441f, 5107.058f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_div_wide_wide()
        {
            float4x2 a0 = float4x2(246.265747f, -269.85614f, -451.619537f, -7.388489f, -308.205566f, -373.3948f, 360.41864f, 25.8097534f);
            float4x2 b0 = float4x2(172.119812f, -77.14111f, -325.8354f, -450.608673f, -261.262146f, -122.449493f, -93.2107849f, -442.005219f);
            float4x2 r0 = float4x2(1.43078089f, 3.49821424f, 1.38603592f, 0.0163966864f, 1.17967939f, 3.04937816f, -3.86670542f, -0.0583924167f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x2 a1 = float4x2(-274.050476f, 127.538574f, -447.671753f, -137.458588f, -136.133179f, 12.4376221f, 228.513f, 356.972351f);
            float4x2 b1 = float4x2(484.362732f, -390.7818f, 402.02533f, 316.6507f, 397.154419f, -303.2622f, -118.591248f, -81.6503f);
            float4x2 r1 = float4x2(-0.565795958f, -0.326367736f, -1.11354113f, -0.434101641f, -0.3427714f, -0.0410127677f, -1.926896f, -4.37196636f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x2 a2 = float4x2(-24.7620544f, 411.6684f, -204.078888f, 11.3654175f, 82.15228f, 37.3894653f, 394.2658f, -429.912781f);
            float4x2 b2 = float4x2(-84.34686f, -488.419434f, 404.160522f, -136.728851f, -19.8327026f, -102.607239f, 166.116028f, -112.840179f);
            float4x2 r2 = float4x2(0.2935741f, -0.8428584f, -0.504945159f, -0.0831237659f, -4.14226341f, -0.364394039f, 2.37343621f, 3.80992651f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x2 a3 = float4x2(315.37384f, -122.665985f, 447.526123f, -210.4815f, -202.42157f, -453.007935f, 173.72699f, -167.121674f);
            float4x2 b3 = float4x2(-218.209686f, 458.517517f, 119.587219f, 356.240417f, -74.50687f, -336.773926f, -216.126312f, 322.385681f);
            float4x2 r3 = float4x2(-1.44527888f, -0.267527372f, 3.742257f, -0.5908412f, 2.71681762f, 1.34513962f, -0.803821564f, -0.5183905f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_div_wide_scalar()
        {
            float4x2 a0 = float4x2(-244.517456f, 69.1123047f, -333.023132f, 257.396851f, 403.2456f, 154.34436f, 131.526611f, -261.8864f);
            float b0 = (-60.0243835f);
            float4x2 r0 = float4x2(4.07363558f, -1.15140378f, 5.548131f, -4.28820467f, -6.71803f, -2.571361f, -2.19121981f, 4.36300039f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x2 a1 = float4x2(-348.9238f, 210.557922f, 287.6424f, 504.372253f, 491.7871f, -26.6315918f, -253.236664f, 272.895142f);
            float b1 = (-275.5387f);
            float4x2 r1 = float4x2(1.26633322f, -0.764168262f, -1.04392743f, -1.83049512f, -1.78482044f, 0.09665282f, 0.91906023f, -0.990405858f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x2 a2 = float4x2(178.096191f, -502.646027f, -84.3248f, -174.690338f, 83.7963257f, 197.042053f, 317.168274f, 403.387146f);
            float b2 = (-460.87558f);
            float4x2 r2 = float4x2(-0.386430085f, 1.0906328f, 0.182966515f, 0.379040122f, -0.181819841f, -0.427538484f, -0.688186347f, -0.875262558f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x2 a3 = float4x2(81.6464844f, -413.5605f, 207.341f, 358.562134f, 20.7490845f, -68.57712f, 310.702454f, 417.4049f);
            float b3 = (60.6068726f);
            float4x2 r3 = float4x2(1.3471489f, -6.82365656f, 3.42108083f, 5.916196f, 0.3423553f, -1.13150728f, 5.12652159f, 6.887089f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float4x2 b0 = float4x2(-422.676147f, 248.129639f, 449.391357f, 245.858154f, -326.6206f, 163.715088f, 333.6645f, 38.2910767f);
            float4x2 r0 = float4x2(-0.09874622f, 0.168209136f, 0.0928759947f, 0.169763222f, -0.1277864f, 0.2549409f, 0.125088736f, 1.0900104f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-472.979767f);
            float4x2 b1 = float4x2(192.230164f, -200.296875f, -490.181519f, -211.10257f, -322.852356f, -137.985291f, 84.32971f, 355.063477f);
            float4x2 r1 = float4x2(-2.46048665f, 2.36139369f, 0.9649074f, 2.24052119f, 1.46500325f, 3.42775488f, -5.60869646f, -1.3320992f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (276.427246f);
            float4x2 b2 = float4x2(-382.988037f, -488.647156f, 344.846f, 168.85498f, -44.1955872f, 420.55072f, -175.6152f, -9.220581f);
            float4x2 r2 = float4x2(-0.7217647f, -0.5656991f, 0.801596165f, 1.637069f, -6.25463438f, 0.6572982f, -1.57405078f, -29.9793739f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-344.194275f);
            float4x2 b3 = float4x2(-449.0715f, 117.704895f, -337.0274f, 239.393433f, -389.355164f, 242.716064f, 496.2765f, 91.74579f);
            float4x2 r3 = float4x2(0.7664576f, -2.924214f, 1.02126491f, -1.43777657f, 0.8840111f, -1.41809428f, -0.693553448f, -3.75160837f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_mod_wide_wide()
        {
            float4x2 a0 = float4x2(-442.309875f, 368.5005f, -1.09390259f, -364.673828f, -197.343933f, -34.0349121f, -101.348572f, 208.318542f);
            float4x2 b0 = float4x2(-43.2450562f, -144.195862f, -62.6404724f, -336.828247f, -154.61026f, -154.029358f, 487.0462f, -469.8291f);
            float4x2 r0 = float4x2(-9.859314f, 80.1087646f, -1.09390259f, -27.8455811f, -42.7336731f, -34.0349121f, -101.348572f, 208.318542f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x2 a1 = float4x2(-140.770325f, 183.44696f, -463.368378f, 83.83911f, -64.71405f, 295.066833f, 212.25708f, 349.6283f);
            float4x2 b1 = float4x2(-145.203766f, -203.384f, -22.52008f, 224.69f, -435.62674f, 12.0955811f, 40.3787842f, 345.784851f);
            float4x2 r1 = float4x2(-140.770325f, 183.44696f, -12.9667664f, 83.83911f, -64.71405f, 4.772888f, 10.3631592f, 3.84344482f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x2 a2 = float4x2(119.875916f, -37.8058167f, 142.41156f, 332.244263f, -464.194275f, -296.147827f, 225.175354f, -212.060272f);
            float4x2 b2 = float4x2(-433.471252f, -355.649963f, 4.015442f, 66.65979f, -221.853638f, -355.056763f, 357.935974f, 71.3753052f);
            float4x2 r2 = float4x2(119.875916f, -37.8058167f, 1.87109375f, 65.6051f, -20.487f, -296.147827f, 225.175354f, -69.30966f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x2 a3 = float4x2(156.985718f, 507.6183f, 270.830444f, 337.7343f, 384.915833f, 432.5182f, 154.292725f, -37.0853271f);
            float4x2 b3 = float4x2(-131.4183f, -473.9876f, 76.2178345f, 92.2102051f, -368.189575f, -77.46716f, 135.230591f, 274.277283f);
            float4x2 r3 = float4x2(25.5674133f, 33.6306763f, 42.17694f, 61.1037f, 16.7262573f, 45.182373f, 19.0621338f, -37.0853271f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_mod_wide_scalar()
        {
            float4x2 a0 = float4x2(-433.417f, -5.51412964f, 393.3944f, 299.41156f, -120.80603f, -502.939026f, -450.807678f, 186.094788f);
            float b0 = (-90.49924f);
            float4x2 r0 = float4x2(-71.4200439f, -5.51412964f, 31.39746f, 27.9138489f, -30.3067932f, -50.44284f, -88.81073f, 5.09631348f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x2 a1 = float4x2(-84.47363f, 433.4547f, -54.60019f, -172.338867f, -429.714661f, 222.361877f, 5.79638672f, 254.5108f);
            float b1 = (-318.7815f);
            float4x2 r1 = float4x2(-84.47363f, 114.673218f, -54.60019f, -172.338867f, -110.933167f, 222.361877f, 5.79638672f, 254.5108f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x2 a2 = float4x2(-433.0937f, -75.3564148f, 252.289124f, -69.4039f, 5.337219f, -279.060425f, 483.5506f, -331.993347f);
            float b2 = (-203.082611f);
            float4x2 r2 = float4x2(-26.9284668f, -75.3564148f, 49.2065125f, -69.4039f, 5.337219f, -75.97781f, 77.385376f, -128.910736f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x2 a3 = float4x2(336f, -124.720764f, 38.1759033f, 271.287f, 405.773621f, -194.761444f, 235.724f, 465.984863f);
            float b3 = (67.8396f);
            float4x2 r3 = float4x2(64.6416f, -56.8811646f, 38.1759033f, 67.76819f, 66.57562f, -59.0822449f, 32.2052f, 58.9472656f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float4x2 b0 = float4x2(-159.140259f, 230.17334f, 14.7793579f, -303.1565f, 399.635f, 206.6947f, 397.0448f, -393.890656f);
            float4x2 r0 = float4x2(-78.14188f, -166.249054f, -12.1590881f, -93.2659f, -396.4224f, -189.727692f, -396.4224f, -2.53173828f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (-372.067078f);
            float4x2 b1 = float4x2(201.012268f, -95.566864f, -258.951477f, 106.983582f, 469.323547f, -34.80899f, 184.836548f, 374.79425f);
            float4x2 r1 = float4x2(-171.05481f, -85.3664856f, -113.1156f, -51.116333f, -372.067078f, -23.9771729f, -2.393982f, -372.067078f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (-131.872711f);
            float4x2 b2 = float4x2(-120.092865f, 4.506653f, -111.401947f, 391.54248f, -218.668884f, 196.377441f, -511.032623f, 499.9535f);
            float4x2 r2 = float4x2(-11.7798462f, -1.179779f, -20.4707642f, -131.872711f, -131.872711f, -131.872711f, -131.872711f, -131.872711f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-433.523071f);
            float4x2 b3 = float4x2(-163.866852f, 177.004028f, 110.650146f, 17.68457f, -95.85297f, -432.440979f, 192.692078f, -268.131775f);
            float4x2 r3 = float4x2(-105.789368f, -79.5150146f, -101.572632f, -9.093384f, -50.1112061f, -1.08209229f, -48.138916f, -165.3913f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_plus()
        {
            float4x2 a0 = float4x2(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f, 190.324646f, -350.3086f);
            float4x2 r0 = float4x2(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f, 190.324646f, -350.3086f);
            TestUtils.AreEqual(+a0, r0);

            float4x2 a1 = float4x2(-320.518463f, -107.00351f, -428.7762f, 377.230164f, 234.773926f, 34.28363f, 258.330383f, 465.355957f);
            float4x2 r1 = float4x2(-320.518463f, -107.00351f, -428.7762f, 377.230164f, 234.773926f, 34.28363f, 258.330383f, 465.355957f);
            TestUtils.AreEqual(+a1, r1);

            float4x2 a2 = float4x2(309.59314f, -230.052673f, 301.7851f, 2.58575439f, 350.2464f, 60.8197632f, -472.4421f, -364.802551f);
            float4x2 r2 = float4x2(309.59314f, -230.052673f, 301.7851f, 2.58575439f, 350.2464f, 60.8197632f, -472.4421f, -364.802551f);
            TestUtils.AreEqual(+a2, r2);

            float4x2 a3 = float4x2(239.152344f, 285.80896f, -273.2638f, -206.686371f, -113.362305f, -351.754883f, -116.536224f, -496.053284f);
            float4x2 r3 = float4x2(239.152344f, 285.80896f, -273.2638f, -206.686371f, -113.362305f, -351.754883f, -116.536224f, -496.053284f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_neg()
        {
            float4x2 a0 = float4x2(420.227173f, -196.2575f, -335.426819f, 509.04364f, -33.0144043f, -498.575317f, -495.837952f, -270.859467f);
            float4x2 r0 = float4x2(-420.227173f, 196.2575f, 335.426819f, -509.04364f, 33.0144043f, 498.575317f, 495.837952f, 270.859467f);
            TestUtils.AreEqual(-a0, r0);

            float4x2 a1 = float4x2(19.68689f, -180.600525f, 223.381287f, -410.392059f, -395.681549f, -349.149475f, -110.9393f, -238.2196f);
            float4x2 r1 = float4x2(-19.68689f, 180.600525f, -223.381287f, 410.392059f, 395.681549f, 349.149475f, 110.9393f, 238.2196f);
            TestUtils.AreEqual(-a1, r1);

            float4x2 a2 = float4x2(292.543518f, 48.29071f, 88.7237549f, 66.1485f, 55.7080078f, 464.541382f, 499.2428f, 175.015015f);
            float4x2 r2 = float4x2(-292.543518f, -48.29071f, -88.7237549f, -66.1485f, -55.7080078f, -464.541382f, -499.2428f, -175.015015f);
            TestUtils.AreEqual(-a2, r2);

            float4x2 a3 = float4x2(196.387573f, 149.660034f, 320.391724f, -359.8338f, 22.0384521f, -159.55426f, 419.822449f, 303.323425f);
            float4x2 r3 = float4x2(-196.387573f, -149.660034f, -320.391724f, 359.8338f, -22.0384521f, 159.55426f, -419.822449f, -303.323425f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_prefix_inc()
        {
            float4x2 a0 = float4x2(-99.79556f, 458.741821f, 96.1790161f, -48.55246f, -315.728973f, -299.230164f, -323.614868f, -456.8903f);
            float4x2 r0 = float4x2(-98.79556f, 459.741821f, 97.1790161f, -47.55246f, -314.728973f, -298.230164f, -322.614868f, -455.8903f);
            TestUtils.AreEqual(++a0, r0);

            float4x2 a1 = float4x2(-76.50766f, 64.0965f, 148.679321f, 363.2849f, -115.559235f, -326.8778f, -179.894653f, 339.8766f);
            float4x2 r1 = float4x2(-75.50766f, 65.0965f, 149.679321f, 364.2849f, -114.559235f, -325.8778f, -178.894653f, 340.8766f);
            TestUtils.AreEqual(++a1, r1);

            float4x2 a2 = float4x2(-38.41043f, 261.625549f, 155.030823f, -396.650238f, 301.3058f, -221.355408f, -429.698151f, -271.2893f);
            float4x2 r2 = float4x2(-37.41043f, 262.625549f, 156.030823f, -395.650238f, 302.3058f, -220.355408f, -428.698151f, -270.2893f);
            TestUtils.AreEqual(++a2, r2);

            float4x2 a3 = float4x2(-264.380066f, 223.232422f, -71.076355f, -388.2279f, 131.283142f, 22.3049316f, -480.760468f, 200.951782f);
            float4x2 r3 = float4x2(-263.380066f, 224.232422f, -70.076355f, -387.2279f, 132.283142f, 23.3049316f, -479.760468f, 201.951782f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_postfix_inc()
        {
            float4x2 a0 = float4x2(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f, 271.454651f, 55.7368774f);
            float4x2 r0 = float4x2(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f, 271.454651f, 55.7368774f);
            TestUtils.AreEqual(a0++, r0);

            float4x2 a1 = float4x2(153.7503f, -427.401062f, 215.110229f, 159.861023f, -333.050446f, 241.4649f, 287.220459f, -170.104645f);
            float4x2 r1 = float4x2(153.7503f, -427.401062f, 215.110229f, 159.861023f, -333.050446f, 241.4649f, 287.220459f, -170.104645f);
            TestUtils.AreEqual(a1++, r1);

            float4x2 a2 = float4x2(-270.652466f, 454.488831f, -449.9273f, 209.522644f, -311.435852f, 69.7314453f, -232.299652f, -341.498535f);
            float4x2 r2 = float4x2(-270.652466f, 454.488831f, -449.9273f, 209.522644f, -311.435852f, 69.7314453f, -232.299652f, -341.498535f);
            TestUtils.AreEqual(a2++, r2);

            float4x2 a3 = float4x2(188.006592f, 25.5656738f, -463.725647f, 504.448975f, -310.144958f, -117.398468f, 403.508728f, -111.279541f);
            float4x2 r3 = float4x2(188.006592f, 25.5656738f, -463.725647f, 504.448975f, -310.144958f, -117.398468f, 403.508728f, -111.279541f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_prefix_dec()
        {
            float4x2 a0 = float4x2(-416.201233f, -96.63788f, -50.14566f, -207.316437f, 439.479065f, -304.400818f, 337.968933f, 246.088989f);
            float4x2 r0 = float4x2(-417.201233f, -97.63788f, -51.14566f, -208.316437f, 438.479065f, -305.400818f, 336.968933f, 245.088989f);
            TestUtils.AreEqual(--a0, r0);

            float4x2 a1 = float4x2(171.964539f, 298.2848f, 326.5078f, 400.7209f, -478.031372f, -326.452972f, -24.5845032f, 112.796875f);
            float4x2 r1 = float4x2(170.964539f, 297.2848f, 325.5078f, 399.7209f, -479.031372f, -327.452972f, -25.5845032f, 111.796875f);
            TestUtils.AreEqual(--a1, r1);

            float4x2 a2 = float4x2(-341.9763f, -79.6352539f, -131.00415f, 147.893677f, -15.7086487f, 188.758423f, 307.791931f, -406.667725f);
            float4x2 r2 = float4x2(-342.9763f, -80.6352539f, -132.00415f, 146.893677f, -16.7086487f, 187.758423f, 306.791931f, -407.667725f);
            TestUtils.AreEqual(--a2, r2);

            float4x2 a3 = float4x2(181.4751f, -505.2157f, -372.241943f, -4.031769f, 83.76776f, -30.6314087f, -436.906555f, -51.668396f);
            float4x2 r3 = float4x2(180.4751f, -506.2157f, -373.241943f, -5.031769f, 82.76776f, -31.6314087f, -437.906555f, -52.668396f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float4x2_operator_postfix_dec()
        {
            float4x2 a0 = float4x2(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f, -281.1117f, -262.0626f);
            float4x2 r0 = float4x2(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f, -281.1117f, -262.0626f);
            TestUtils.AreEqual(a0--, r0);

            float4x2 a1 = float4x2(-182.405731f, -129.232666f, -332.154968f, -261.0089f, 205.461121f, -230.227783f, -483.066528f, 378.641235f);
            float4x2 r1 = float4x2(-182.405731f, -129.232666f, -332.154968f, -261.0089f, 205.461121f, -230.227783f, -483.066528f, 378.641235f);
            TestUtils.AreEqual(a1--, r1);

            float4x2 a2 = float4x2(487.344849f, -357.0542f, -396.302063f, 279.424255f, 115.867737f, -20.8232117f, 323.4054f, 379.156128f);
            float4x2 r2 = float4x2(487.344849f, -357.0542f, -396.302063f, 279.424255f, 115.867737f, -20.8232117f, 323.4054f, 379.156128f);
            TestUtils.AreEqual(a2--, r2);

            float4x2 a3 = float4x2(311.299f, -428.2567f, -425.2884f, -194.6413f, -258.848358f, -208.985779f, -313.4259f, 178.3125f);
            float4x2 r3 = float4x2(311.299f, -428.2567f, -425.2884f, -194.6413f, -258.848358f, -208.985779f, -313.4259f, 178.3125f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
