namespace MCVP
{
    public static class MapHelper
    {
        #region MapColor
        public sealed class MapColor
        {
            #region Public Static Variables
            public static readonly MapColor MapColor0 = new MapColor(0, 0, 0, 0, 0);
            public static readonly MapColor MapColor1 = new MapColor(1, 0, 0, 0, 0);
            public static readonly MapColor MapColor2 = new MapColor(2, 0, 0, 0, 0);
            public static readonly MapColor MapColor3 = new MapColor(3, 0, 0, 0, 0);
            public static readonly MapColor MapColor4 = new MapColor(4, 89, 125, 39, 255);
            public static readonly MapColor MapColor5 = new MapColor(5, 109, 153, 48, 255);
            public static readonly MapColor MapColor6 = new MapColor(6, 127, 178, 56, 255);
            public static readonly MapColor MapColor7 = new MapColor(7, 67, 94, 29, 255);
            public static readonly MapColor MapColor8 = new MapColor(8, 174, 164, 115, 255);
            public static readonly MapColor MapColor9 = new MapColor(9, 213, 201, 140, 255);
            public static readonly MapColor MapColor10 = new MapColor(10, 247, 233, 163, 255);
            public static readonly MapColor MapColor11 = new MapColor(11, 130, 123, 86, 255);
            public static readonly MapColor MapColor12 = new MapColor(12, 140, 140, 140, 255);
            public static readonly MapColor MapColor13 = new MapColor(13, 171, 171, 171, 255);
            public static readonly MapColor MapColor14 = new MapColor(14, 199, 199, 199, 255);
            public static readonly MapColor MapColor15 = new MapColor(15, 105, 105, 105, 255);
            public static readonly MapColor MapColor16 = new MapColor(16, 180, 0, 0, 255);
            public static readonly MapColor MapColor17 = new MapColor(17, 220, 0, 0, 255);
            public static readonly MapColor MapColor18 = new MapColor(18, 255, 0, 0, 255);
            public static readonly MapColor MapColor19 = new MapColor(19, 135, 0, 0, 255);
            public static readonly MapColor MapColor20 = new MapColor(20, 112, 112, 180, 255);
            public static readonly MapColor MapColor21 = new MapColor(21, 138, 138, 220, 255);
            public static readonly MapColor MapColor22 = new MapColor(22, 160, 160, 255, 255);
            public static readonly MapColor MapColor23 = new MapColor(23, 84, 84, 135, 255);
            public static readonly MapColor MapColor24 = new MapColor(24, 117, 117, 117, 255);
            public static readonly MapColor MapColor25 = new MapColor(25, 144, 144, 144, 255);
            public static readonly MapColor MapColor26 = new MapColor(26, 167, 167, 167, 255);
            public static readonly MapColor MapColor27 = new MapColor(27, 88, 88, 88, 255);
            public static readonly MapColor MapColor28 = new MapColor(28, 0, 87, 0, 255);
            public static readonly MapColor MapColor29 = new MapColor(29, 0, 106, 0, 255);
            public static readonly MapColor MapColor30 = new MapColor(30, 0, 124, 0, 255);
            public static readonly MapColor MapColor31 = new MapColor(31, 0, 65, 0, 255);
            public static readonly MapColor MapColor32 = new MapColor(32, 180, 180, 180, 255);
            public static readonly MapColor MapColor33 = new MapColor(33, 220, 220, 220, 255);
            public static readonly MapColor MapColor34 = new MapColor(34, 255, 255, 255, 255);
            public static readonly MapColor MapColor35 = new MapColor(35, 135, 135, 135, 255);
            public static readonly MapColor MapColor36 = new MapColor(36, 115, 118, 129, 255);
            public static readonly MapColor MapColor37 = new MapColor(37, 141, 144, 158, 255);
            public static readonly MapColor MapColor38 = new MapColor(38, 164, 168, 184, 255);
            public static readonly MapColor MapColor39 = new MapColor(39, 86, 88, 97, 255);
            public static readonly MapColor MapColor40 = new MapColor(40, 106, 76, 54, 255);
            public static readonly MapColor MapColor41 = new MapColor(41, 130, 94, 66, 255);
            public static readonly MapColor MapColor42 = new MapColor(42, 151, 109, 77, 255);
            public static readonly MapColor MapColor43 = new MapColor(43, 79, 57, 40, 255);
            public static readonly MapColor MapColor44 = new MapColor(44, 79, 79, 79, 255);
            public static readonly MapColor MapColor45 = new MapColor(45, 96, 96, 96, 255);
            public static readonly MapColor MapColor46 = new MapColor(46, 112, 112, 112, 255);
            public static readonly MapColor MapColor47 = new MapColor(47, 59, 59, 59, 255);
            public static readonly MapColor MapColor48 = new MapColor(48, 45, 45, 180, 255);
            public static readonly MapColor MapColor49 = new MapColor(49, 55, 55, 220, 255);
            public static readonly MapColor MapColor50 = new MapColor(50, 64, 64, 255, 255);
            public static readonly MapColor MapColor51 = new MapColor(51, 33, 33, 135, 255);
            public static readonly MapColor MapColor52 = new MapColor(52, 100, 84, 50, 255);
            public static readonly MapColor MapColor53 = new MapColor(53, 123, 102, 62, 255);
            public static readonly MapColor MapColor54 = new MapColor(54, 143, 119, 72, 255);
            public static readonly MapColor MapColor55 = new MapColor(55, 75, 63, 38, 255);
            public static readonly MapColor MapColor56 = new MapColor(56, 180, 177, 172, 255);
            public static readonly MapColor MapColor57 = new MapColor(57, 220, 217, 211, 255);
            public static readonly MapColor MapColor58 = new MapColor(58, 255, 252, 245, 255);
            public static readonly MapColor MapColor59 = new MapColor(59, 135, 133, 129, 255);
            public static readonly MapColor MapColor60 = new MapColor(60, 152, 89, 36, 255);
            public static readonly MapColor MapColor61 = new MapColor(61, 186, 109, 44, 255);
            public static readonly MapColor MapColor62 = new MapColor(62, 216, 127, 51, 255);
            public static readonly MapColor MapColor63 = new MapColor(63, 114, 67, 27, 255);
            public static readonly MapColor MapColor64 = new MapColor(64, 125, 53, 152, 255);
            public static readonly MapColor MapColor65 = new MapColor(65, 153, 65, 186, 255);
            public static readonly MapColor MapColor66 = new MapColor(66, 178, 76, 216, 255);
            public static readonly MapColor MapColor67 = new MapColor(67, 94, 40, 114, 255);
            public static readonly MapColor MapColor68 = new MapColor(68, 72, 108, 152, 255);
            public static readonly MapColor MapColor69 = new MapColor(69, 88, 132, 186, 255);
            public static readonly MapColor MapColor70 = new MapColor(70, 102, 153, 216, 255);
            public static readonly MapColor MapColor71 = new MapColor(71, 54, 81, 114, 255);
            public static readonly MapColor MapColor72 = new MapColor(72, 161, 161, 36, 255);
            public static readonly MapColor MapColor73 = new MapColor(73, 197, 197, 44, 255);
            public static readonly MapColor MapColor74 = new MapColor(74, 229, 229, 51, 255);
            public static readonly MapColor MapColor75 = new MapColor(75, 121, 121, 27, 255);
            public static readonly MapColor MapColor76 = new MapColor(76, 89, 144, 17, 255);
            public static readonly MapColor MapColor77 = new MapColor(77, 109, 176, 21, 255);
            public static readonly MapColor MapColor78 = new MapColor(78, 127, 204, 25, 255);
            public static readonly MapColor MapColor79 = new MapColor(79, 67, 108, 13, 255);
            public static readonly MapColor MapColor80 = new MapColor(80, 170, 89, 116, 255);
            public static readonly MapColor MapColor81 = new MapColor(81, 208, 109, 142, 255);
            public static readonly MapColor MapColor82 = new MapColor(82, 242, 127, 165, 255);
            public static readonly MapColor MapColor83 = new MapColor(83, 128, 67, 87, 255);
            public static readonly MapColor MapColor84 = new MapColor(84, 53, 53, 53, 255);
            public static readonly MapColor MapColor85 = new MapColor(85, 65, 65, 65, 255);
            public static readonly MapColor MapColor86 = new MapColor(86, 76, 76, 76, 255);
            public static readonly MapColor MapColor87 = new MapColor(87, 40, 40, 40, 255);
            public static readonly MapColor MapColor88 = new MapColor(88, 108, 108, 108, 255);
            public static readonly MapColor MapColor89 = new MapColor(89, 132, 132, 132, 255);
            public static readonly MapColor MapColor90 = new MapColor(90, 153, 153, 153, 255);
            public static readonly MapColor MapColor91 = new MapColor(91, 81, 81, 81, 255);
            public static readonly MapColor MapColor92 = new MapColor(92, 53, 89, 108, 255);
            public static readonly MapColor MapColor93 = new MapColor(93, 65, 109, 132, 255);
            public static readonly MapColor MapColor94 = new MapColor(94, 76, 127, 153, 255);
            public static readonly MapColor MapColor95 = new MapColor(95, 40, 67, 81, 255);
            public static readonly MapColor MapColor96 = new MapColor(96, 89, 44, 125, 255);
            public static readonly MapColor MapColor97 = new MapColor(97, 109, 54, 153, 255);
            public static readonly MapColor MapColor98 = new MapColor(98, 127, 63, 178, 255);
            public static readonly MapColor MapColor99 = new MapColor(99, 67, 33, 94, 255);
            public static readonly MapColor MapColor100 = new MapColor(100, 36, 53, 125, 255);
            public static readonly MapColor MapColor101 = new MapColor(101, 44, 65, 153, 255);
            public static readonly MapColor MapColor102 = new MapColor(102, 51, 76, 178, 255);
            public static readonly MapColor MapColor103 = new MapColor(103, 27, 40, 94, 255);
            public static readonly MapColor MapColor104 = new MapColor(104, 72, 53, 36, 255);
            public static readonly MapColor MapColor105 = new MapColor(105, 88, 65, 44, 255);
            public static readonly MapColor MapColor106 = new MapColor(106, 102, 76, 51, 255);
            public static readonly MapColor MapColor107 = new MapColor(107, 54, 40, 27, 255);
            public static readonly MapColor MapColor108 = new MapColor(108, 72, 89, 36, 255);
            public static readonly MapColor MapColor109 = new MapColor(109, 88, 109, 44, 255);
            public static readonly MapColor MapColor110 = new MapColor(110, 102, 127, 51, 255);
            public static readonly MapColor MapColor111 = new MapColor(111, 54, 67, 27, 255);
            public static readonly MapColor MapColor112 = new MapColor(112, 108, 36, 36, 255);
            public static readonly MapColor MapColor113 = new MapColor(113, 132, 44, 44, 255);
            public static readonly MapColor MapColor114 = new MapColor(114, 153, 51, 51, 255);
            public static readonly MapColor MapColor115 = new MapColor(115, 81, 27, 27, 255);
            public static readonly MapColor MapColor116 = new MapColor(116, 17, 17, 17, 255);
            public static readonly MapColor MapColor117 = new MapColor(117, 21, 21, 21, 255);
            public static readonly MapColor MapColor118 = new MapColor(118, 25, 25, 25, 255);
            public static readonly MapColor MapColor119 = new MapColor(119, 13, 13, 13, 255);
            public static readonly MapColor MapColor120 = new MapColor(120, 176, 168, 54, 255);
            public static readonly MapColor MapColor121 = new MapColor(121, 215, 205, 66, 255);
            public static readonly MapColor MapColor122 = new MapColor(122, 250, 238, 77, 255);
            public static readonly MapColor MapColor123 = new MapColor(123, 132, 126, 40, 255);
            public static readonly MapColor MapColor124 = new MapColor(124, 64, 154, 150, 255);
            public static readonly MapColor MapColor125 = new MapColor(125, 79, 188, 183, 255);
            public static readonly MapColor MapColor126 = new MapColor(126, 92, 219, 213, 255);
            public static readonly MapColor MapColor127 = new MapColor(127, 48, 115, 112, 255);
            public static readonly MapColor MapColor128 = new MapColor(128, 52, 90, 180, 255);
            public static readonly MapColor MapColor129 = new MapColor(129, 63, 110, 220, 255);
            public static readonly MapColor MapColor130 = new MapColor(130, 74, 128, 255, 255);
            public static readonly MapColor MapColor131 = new MapColor(131, 39, 67, 135, 255);
            public static readonly MapColor MapColor132 = new MapColor(132, 0, 153, 40, 255);
            public static readonly MapColor MapColor133 = new MapColor(133, 0, 187, 50, 255);
            public static readonly MapColor MapColor134 = new MapColor(134, 0, 217, 58, 255);
            public static readonly MapColor MapColor135 = new MapColor(135, 0, 114, 30, 255);
            public static readonly MapColor MapColor136 = new MapColor(136, 91, 60, 34, 255);
            public static readonly MapColor MapColor137 = new MapColor(137, 111, 74, 42, 255);
            public static readonly MapColor MapColor138 = new MapColor(138, 129, 86, 49, 255);
            public static readonly MapColor MapColor139 = new MapColor(139, 68, 45, 25, 255);
            public static readonly MapColor MapColor140 = new MapColor(140, 79, 1, 0, 255);
            public static readonly MapColor MapColor141 = new MapColor(141, 96, 1, 0, 255);
            public static readonly MapColor MapColor142 = new MapColor(142, 112, 2, 0, 255);
            public static readonly MapColor MapColor143 = new MapColor(143, 59, 1, 0, 255);
            public static readonly MapColor MapColor144 = new MapColor(144, 147, 124, 113, 255);
            public static readonly MapColor MapColor145 = new MapColor(145, 180, 152, 138, 255);
            public static readonly MapColor MapColor146 = new MapColor(146, 209, 177, 161, 255);
            public static readonly MapColor MapColor147 = new MapColor(147, 110, 93, 85, 255);
            public static readonly MapColor MapColor148 = new MapColor(148, 112, 57, 25, 255);
            public static readonly MapColor MapColor149 = new MapColor(149, 137, 70, 31, 255);
            public static readonly MapColor MapColor150 = new MapColor(150, 159, 82, 36, 255);
            public static readonly MapColor MapColor151 = new MapColor(151, 84, 43, 19, 255);
            public static readonly MapColor MapColor152 = new MapColor(152, 105, 61, 76, 255);
            public static readonly MapColor MapColor153 = new MapColor(153, 128, 75, 93, 255);
            public static readonly MapColor MapColor154 = new MapColor(154, 149, 87, 108, 255);
            public static readonly MapColor MapColor155 = new MapColor(155, 78, 46, 57, 255);
            public static readonly MapColor MapColor156 = new MapColor(156, 79, 76, 97, 255);
            public static readonly MapColor MapColor157 = new MapColor(157, 96, 93, 119, 255);
            public static readonly MapColor MapColor158 = new MapColor(158, 112, 108, 138, 255);
            public static readonly MapColor MapColor159 = new MapColor(159, 59, 57, 73, 255);
            public static readonly MapColor MapColor160 = new MapColor(160, 131, 93, 25, 255);
            public static readonly MapColor MapColor161 = new MapColor(161, 160, 114, 31, 255);
            public static readonly MapColor MapColor162 = new MapColor(162, 186, 133, 36, 255);
            public static readonly MapColor MapColor163 = new MapColor(163, 98, 70, 19, 255);
            public static readonly MapColor MapColor164 = new MapColor(164, 72, 82, 37, 255);
            public static readonly MapColor MapColor165 = new MapColor(165, 88, 100, 45, 255);
            public static readonly MapColor MapColor166 = new MapColor(166, 103, 117, 53, 255);
            public static readonly MapColor MapColor167 = new MapColor(167, 54, 61, 28, 255);
            public static readonly MapColor MapColor168 = new MapColor(168, 112, 54, 55, 255);
            public static readonly MapColor MapColor169 = new MapColor(169, 138, 66, 67, 255);
            public static readonly MapColor MapColor170 = new MapColor(170, 160, 77, 78, 255);
            public static readonly MapColor MapColor171 = new MapColor(171, 84, 40, 41, 255);
            public static readonly MapColor MapColor172 = new MapColor(172, 40, 28, 24, 255);
            public static readonly MapColor MapColor173 = new MapColor(173, 49, 35, 30, 255);
            public static readonly MapColor MapColor174 = new MapColor(174, 57, 41, 35, 255);
            public static readonly MapColor MapColor175 = new MapColor(175, 30, 21, 18, 255);
            public static readonly MapColor MapColor176 = new MapColor(176, 95, 75, 69, 255);
            public static readonly MapColor MapColor177 = new MapColor(177, 116, 92, 84, 255);
            public static readonly MapColor MapColor178 = new MapColor(178, 135, 107, 98, 255);
            public static readonly MapColor MapColor179 = new MapColor(179, 71, 56, 51, 255);
            public static readonly MapColor MapColor180 = new MapColor(180, 61, 64, 64, 255);
            public static readonly MapColor MapColor181 = new MapColor(181, 75, 79, 79, 255);
            public static readonly MapColor MapColor182 = new MapColor(182, 87, 92, 92, 255);
            public static readonly MapColor MapColor183 = new MapColor(183, 46, 48, 48, 255);
            public static readonly MapColor MapColor184 = new MapColor(184, 86, 51, 62, 255);
            public static readonly MapColor MapColor185 = new MapColor(185, 105, 62, 75, 255);
            public static readonly MapColor MapColor186 = new MapColor(186, 122, 73, 88, 255);
            public static readonly MapColor MapColor187 = new MapColor(187, 64, 38, 46, 255);
            public static readonly MapColor MapColor188 = new MapColor(188, 53, 43, 64, 255);
            public static readonly MapColor MapColor189 = new MapColor(189, 65, 53, 79, 255);
            public static readonly MapColor MapColor190 = new MapColor(190, 76, 62, 92, 255);
            public static readonly MapColor MapColor191 = new MapColor(191, 40, 32, 48, 255);
            public static readonly MapColor MapColor192 = new MapColor(192, 53, 35, 24, 255);
            public static readonly MapColor MapColor193 = new MapColor(193, 65, 43, 30, 255);
            public static readonly MapColor MapColor194 = new MapColor(194, 76, 50, 35, 255);
            public static readonly MapColor MapColor195 = new MapColor(195, 40, 26, 18, 255);
            public static readonly MapColor MapColor196 = new MapColor(196, 53, 57, 29, 255);
            public static readonly MapColor MapColor197 = new MapColor(197, 65, 70, 36, 255);
            public static readonly MapColor MapColor198 = new MapColor(198, 76, 82, 42, 255);
            public static readonly MapColor MapColor199 = new MapColor(199, 40, 43, 22, 255);
            public static readonly MapColor MapColor200 = new MapColor(200, 100, 42, 32, 255);
            public static readonly MapColor MapColor201 = new MapColor(201, 122, 51, 39, 255);
            public static readonly MapColor MapColor202 = new MapColor(202, 142, 60, 46, 255);
            public static readonly MapColor MapColor203 = new MapColor(203, 75, 31, 24, 255);
            public static readonly MapColor MapColor204 = new MapColor(204, 26, 15, 11, 255);
            public static readonly MapColor MapColor205 = new MapColor(205, 31, 18, 13, 255);
            public static readonly MapColor MapColor206 = new MapColor(206, 37, 22, 16, 255);
            public static readonly MapColor MapColor207 = new MapColor(207, 19, 11, 8, 255);
            public static readonly MapColor MapColor208 = new MapColor(208, 133, 33, 34, 255);
            public static readonly MapColor MapColor209 = new MapColor(209, 163, 41, 42, 255);
            public static readonly MapColor MapColor210 = new MapColor(210, 189, 48, 49, 255);
            public static readonly MapColor MapColor211 = new MapColor(211, 100, 25, 25, 255);
            public static readonly MapColor MapColor212 = new MapColor(212, 104, 44, 68, 255);
            public static readonly MapColor MapColor213 = new MapColor(213, 127, 54, 83, 255);
            public static readonly MapColor MapColor214 = new MapColor(214, 148, 63, 97, 255);
            public static readonly MapColor MapColor215 = new MapColor(215, 78, 33, 51, 255);
            public static readonly MapColor MapColor216 = new MapColor(216, 64, 17, 20, 255);
            public static readonly MapColor MapColor217 = new MapColor(217, 79, 21, 25, 255);
            public static readonly MapColor MapColor218 = new MapColor(218, 92, 25, 29, 255);
            public static readonly MapColor MapColor219 = new MapColor(219, 48, 13, 15, 255);
            public static readonly MapColor MapColor220 = new MapColor(220, 15, 88, 94, 255);
            public static readonly MapColor MapColor221 = new MapColor(221, 18, 108, 115, 255);
            public static readonly MapColor MapColor222 = new MapColor(222, 22, 126, 134, 255);
            public static readonly MapColor MapColor223 = new MapColor(223, 11, 66, 70, 255);
            public static readonly MapColor MapColor224 = new MapColor(224, 40, 100, 98, 255);
            public static readonly MapColor MapColor225 = new MapColor(225, 50, 122, 120, 255);
            public static readonly MapColor MapColor226 = new MapColor(226, 58, 142, 140, 255);
            public static readonly MapColor MapColor227 = new MapColor(227, 30, 75, 74, 255);
            public static readonly MapColor MapColor228 = new MapColor(228, 60, 31, 43, 255);
            public static readonly MapColor MapColor229 = new MapColor(229, 74, 37, 53, 255);
            public static readonly MapColor MapColor230 = new MapColor(230, 86, 44, 62, 255);
            public static readonly MapColor MapColor231 = new MapColor(231, 45, 23, 32, 255);
            public static readonly MapColor MapColor232 = new MapColor(232, 14, 127, 93, 255);
            public static readonly MapColor MapColor233 = new MapColor(233, 17, 155, 114, 255);
            public static readonly MapColor MapColor234 = new MapColor(234, 20, 180, 133, 255);
            public static readonly MapColor MapColor235 = new MapColor(235, 10, 95, 70, 255);
            public static readonly MapColor MapColor236 = new MapColor(236, 70, 70, 70, 255);
            public static readonly MapColor MapColor237 = new MapColor(237, 86, 86, 86, 255);
            public static readonly MapColor MapColor238 = new MapColor(238, 100, 100, 100, 255);
            public static readonly MapColor MapColor239 = new MapColor(239, 52, 52, 52, 255);
            public static readonly MapColor MapColor240 = new MapColor(240, 152, 123, 103, 255);
            public static readonly MapColor MapColor241 = new MapColor(241, 186, 150, 126, 255);
            public static readonly MapColor MapColor242 = new MapColor(242, 216, 175, 147, 255);
            public static readonly MapColor MapColor243 = new MapColor(243, 114, 92, 77, 255);
            public static readonly MapColor MapColor244 = new MapColor(244, 89, 117, 105, 255);
            public static readonly MapColor MapColor245 = new MapColor(245, 109, 144, 129, 255);
            public static readonly MapColor MapColor246 = new MapColor(246, 127, 167, 150, 255);
            public static readonly MapColor MapColor247 = new MapColor(247, 67, 88, 79, 255);
            #endregion
            #region Public Variables
            public readonly byte ID = 0;
            public readonly byte R = 0;
            public readonly byte G = 0;
            public readonly byte B = 0;
            public readonly byte A = 0;
            #endregion
            #region Private Constructors
            private MapColor(byte id, byte r, byte g, byte b, byte a)
            {
                ID = id;
                R = r;
                G = g;
                B = b;
                A = a;
            }
            #endregion
        }
        #endregion
        #region MapColorTable
        public static readonly MapColor[] MapColorTable = new MapColor[248]
        {
            MapColor.MapColor0,
            MapColor.MapColor1,
            MapColor.MapColor2,
            MapColor.MapColor3,
            MapColor.MapColor4,
            MapColor.MapColor5,
            MapColor.MapColor6,
            MapColor.MapColor7,
            MapColor.MapColor8,
            MapColor.MapColor9,
            MapColor.MapColor10,
            MapColor.MapColor11,
            MapColor.MapColor12,
            MapColor.MapColor13,
            MapColor.MapColor14,
            MapColor.MapColor15,
            MapColor.MapColor16,
            MapColor.MapColor17,
            MapColor.MapColor18,
            MapColor.MapColor19,
            MapColor.MapColor20,
            MapColor.MapColor21,
            MapColor.MapColor22,
            MapColor.MapColor23,
            MapColor.MapColor24,
            MapColor.MapColor25,
            MapColor.MapColor26,
            MapColor.MapColor27,
            MapColor.MapColor28,
            MapColor.MapColor29,
            MapColor.MapColor30,
            MapColor.MapColor31,
            MapColor.MapColor32,
            MapColor.MapColor33,
            MapColor.MapColor34,
            MapColor.MapColor35,
            MapColor.MapColor36,
            MapColor.MapColor37,
            MapColor.MapColor38,
            MapColor.MapColor39,
            MapColor.MapColor40,
            MapColor.MapColor41,
            MapColor.MapColor42,
            MapColor.MapColor43,
            MapColor.MapColor44,
            MapColor.MapColor45,
            MapColor.MapColor46,
            MapColor.MapColor47,
            MapColor.MapColor48,
            MapColor.MapColor49,
            MapColor.MapColor50,
            MapColor.MapColor51,
            MapColor.MapColor52,
            MapColor.MapColor53,
            MapColor.MapColor54,
            MapColor.MapColor55,
            MapColor.MapColor56,
            MapColor.MapColor57,
            MapColor.MapColor58,
            MapColor.MapColor59,
            MapColor.MapColor60,
            MapColor.MapColor61,
            MapColor.MapColor62,
            MapColor.MapColor63,
            MapColor.MapColor64,
            MapColor.MapColor65,
            MapColor.MapColor66,
            MapColor.MapColor67,
            MapColor.MapColor68,
            MapColor.MapColor69,
            MapColor.MapColor70,
            MapColor.MapColor71,
            MapColor.MapColor72,
            MapColor.MapColor73,
            MapColor.MapColor74,
            MapColor.MapColor75,
            MapColor.MapColor76,
            MapColor.MapColor77,
            MapColor.MapColor78,
            MapColor.MapColor79,
            MapColor.MapColor80,
            MapColor.MapColor81,
            MapColor.MapColor82,
            MapColor.MapColor83,
            MapColor.MapColor84,
            MapColor.MapColor85,
            MapColor.MapColor86,
            MapColor.MapColor87,
            MapColor.MapColor88,
            MapColor.MapColor89,
            MapColor.MapColor90,
            MapColor.MapColor91,
            MapColor.MapColor92,
            MapColor.MapColor93,
            MapColor.MapColor94,
            MapColor.MapColor95,
            MapColor.MapColor96,
            MapColor.MapColor97,
            MapColor.MapColor98,
            MapColor.MapColor99,
            MapColor.MapColor100,
            MapColor.MapColor101,
            MapColor.MapColor102,
            MapColor.MapColor103,
            MapColor.MapColor104,
            MapColor.MapColor105,
            MapColor.MapColor106,
            MapColor.MapColor107,
            MapColor.MapColor108,
            MapColor.MapColor109,
            MapColor.MapColor110,
            MapColor.MapColor111,
            MapColor.MapColor112,
            MapColor.MapColor113,
            MapColor.MapColor114,
            MapColor.MapColor115,
            MapColor.MapColor116,
            MapColor.MapColor117,
            MapColor.MapColor118,
            MapColor.MapColor119,
            MapColor.MapColor120,
            MapColor.MapColor121,
            MapColor.MapColor122,
            MapColor.MapColor123,
            MapColor.MapColor124,
            MapColor.MapColor125,
            MapColor.MapColor126,
            MapColor.MapColor127,
            MapColor.MapColor128,
            MapColor.MapColor129,
            MapColor.MapColor130,
            MapColor.MapColor131,
            MapColor.MapColor132,
            MapColor.MapColor133,
            MapColor.MapColor134,
            MapColor.MapColor135,
            MapColor.MapColor136,
            MapColor.MapColor137,
            MapColor.MapColor138,
            MapColor.MapColor139,
            MapColor.MapColor140,
            MapColor.MapColor141,
            MapColor.MapColor142,
            MapColor.MapColor143,
            MapColor.MapColor144,
            MapColor.MapColor145,
            MapColor.MapColor146,
            MapColor.MapColor147,
            MapColor.MapColor148,
            MapColor.MapColor149,
            MapColor.MapColor150,
            MapColor.MapColor151,
            MapColor.MapColor152,
            MapColor.MapColor153,
            MapColor.MapColor154,
            MapColor.MapColor155,
            MapColor.MapColor156,
            MapColor.MapColor157,
            MapColor.MapColor158,
            MapColor.MapColor159,
            MapColor.MapColor160,
            MapColor.MapColor161,
            MapColor.MapColor162,
            MapColor.MapColor163,
            MapColor.MapColor164,
            MapColor.MapColor165,
            MapColor.MapColor166,
            MapColor.MapColor167,
            MapColor.MapColor168,
            MapColor.MapColor169,
            MapColor.MapColor170,
            MapColor.MapColor171,
            MapColor.MapColor172,
            MapColor.MapColor173,
            MapColor.MapColor174,
            MapColor.MapColor175,
            MapColor.MapColor176,
            MapColor.MapColor177,
            MapColor.MapColor178,
            MapColor.MapColor179,
            MapColor.MapColor180,
            MapColor.MapColor181,
            MapColor.MapColor182,
            MapColor.MapColor183,
            MapColor.MapColor184,
            MapColor.MapColor185,
            MapColor.MapColor186,
            MapColor.MapColor187,
            MapColor.MapColor188,
            MapColor.MapColor189,
            MapColor.MapColor190,
            MapColor.MapColor191,
            MapColor.MapColor192,
            MapColor.MapColor193,
            MapColor.MapColor194,
            MapColor.MapColor195,
            MapColor.MapColor196,
            MapColor.MapColor197,
            MapColor.MapColor198,
            MapColor.MapColor199,
            MapColor.MapColor200,
            MapColor.MapColor201,
            MapColor.MapColor202,
            MapColor.MapColor203,
            MapColor.MapColor204,
            MapColor.MapColor205,
            MapColor.MapColor206,
            MapColor.MapColor207,
            MapColor.MapColor208,
            MapColor.MapColor209,
            MapColor.MapColor210,
            MapColor.MapColor211,
            MapColor.MapColor212,
            MapColor.MapColor213,
            MapColor.MapColor214,
            MapColor.MapColor215,
            MapColor.MapColor216,
            MapColor.MapColor217,
            MapColor.MapColor218,
            MapColor.MapColor219,
            MapColor.MapColor220,
            MapColor.MapColor221,
            MapColor.MapColor222,
            MapColor.MapColor223,
            MapColor.MapColor224,
            MapColor.MapColor225,
            MapColor.MapColor226,
            MapColor.MapColor227,
            MapColor.MapColor228,
            MapColor.MapColor229,
            MapColor.MapColor230,
            MapColor.MapColor231,
            MapColor.MapColor232,
            MapColor.MapColor233,
            MapColor.MapColor234,
            MapColor.MapColor235,
            MapColor.MapColor236,
            MapColor.MapColor237,
            MapColor.MapColor238,
            MapColor.MapColor239,
            MapColor.MapColor240,
            MapColor.MapColor241,
            MapColor.MapColor242,
            MapColor.MapColor243,
            MapColor.MapColor244,
            MapColor.MapColor245,
            MapColor.MapColor246,
            MapColor.MapColor247
        };
        #endregion
        #region OpaqueMapColors
        public static readonly MapColor[] OpaqueMapColors = new MapColor[244]
        {
            MapColor.MapColor4,
            MapColor.MapColor5,
            MapColor.MapColor6,
            MapColor.MapColor7,
            MapColor.MapColor8,
            MapColor.MapColor9,
            MapColor.MapColor10,
            MapColor.MapColor11,
            MapColor.MapColor12,
            MapColor.MapColor13,
            MapColor.MapColor14,
            MapColor.MapColor15,
            MapColor.MapColor16,
            MapColor.MapColor17,
            MapColor.MapColor18,
            MapColor.MapColor19,
            MapColor.MapColor20,
            MapColor.MapColor21,
            MapColor.MapColor22,
            MapColor.MapColor23,
            MapColor.MapColor24,
            MapColor.MapColor25,
            MapColor.MapColor26,
            MapColor.MapColor27,
            MapColor.MapColor28,
            MapColor.MapColor29,
            MapColor.MapColor30,
            MapColor.MapColor31,
            MapColor.MapColor32,
            MapColor.MapColor33,
            MapColor.MapColor34,
            MapColor.MapColor35,
            MapColor.MapColor36,
            MapColor.MapColor37,
            MapColor.MapColor38,
            MapColor.MapColor39,
            MapColor.MapColor40,
            MapColor.MapColor41,
            MapColor.MapColor42,
            MapColor.MapColor43,
            MapColor.MapColor44,
            MapColor.MapColor45,
            MapColor.MapColor46,
            MapColor.MapColor47,
            MapColor.MapColor48,
            MapColor.MapColor49,
            MapColor.MapColor50,
            MapColor.MapColor51,
            MapColor.MapColor52,
            MapColor.MapColor53,
            MapColor.MapColor54,
            MapColor.MapColor55,
            MapColor.MapColor56,
            MapColor.MapColor57,
            MapColor.MapColor58,
            MapColor.MapColor59,
            MapColor.MapColor60,
            MapColor.MapColor61,
            MapColor.MapColor62,
            MapColor.MapColor63,
            MapColor.MapColor64,
            MapColor.MapColor65,
            MapColor.MapColor66,
            MapColor.MapColor67,
            MapColor.MapColor68,
            MapColor.MapColor69,
            MapColor.MapColor70,
            MapColor.MapColor71,
            MapColor.MapColor72,
            MapColor.MapColor73,
            MapColor.MapColor74,
            MapColor.MapColor75,
            MapColor.MapColor76,
            MapColor.MapColor77,
            MapColor.MapColor78,
            MapColor.MapColor79,
            MapColor.MapColor80,
            MapColor.MapColor81,
            MapColor.MapColor82,
            MapColor.MapColor83,
            MapColor.MapColor84,
            MapColor.MapColor85,
            MapColor.MapColor86,
            MapColor.MapColor87,
            MapColor.MapColor88,
            MapColor.MapColor89,
            MapColor.MapColor90,
            MapColor.MapColor91,
            MapColor.MapColor92,
            MapColor.MapColor93,
            MapColor.MapColor94,
            MapColor.MapColor95,
            MapColor.MapColor96,
            MapColor.MapColor97,
            MapColor.MapColor98,
            MapColor.MapColor99,
            MapColor.MapColor100,
            MapColor.MapColor101,
            MapColor.MapColor102,
            MapColor.MapColor103,
            MapColor.MapColor104,
            MapColor.MapColor105,
            MapColor.MapColor106,
            MapColor.MapColor107,
            MapColor.MapColor108,
            MapColor.MapColor109,
            MapColor.MapColor110,
            MapColor.MapColor111,
            MapColor.MapColor112,
            MapColor.MapColor113,
            MapColor.MapColor114,
            MapColor.MapColor115,
            MapColor.MapColor116,
            MapColor.MapColor117,
            MapColor.MapColor118,
            MapColor.MapColor119,
            MapColor.MapColor120,
            MapColor.MapColor121,
            MapColor.MapColor122,
            MapColor.MapColor123,
            MapColor.MapColor124,
            MapColor.MapColor125,
            MapColor.MapColor126,
            MapColor.MapColor127,
            MapColor.MapColor128,
            MapColor.MapColor129,
            MapColor.MapColor130,
            MapColor.MapColor131,
            MapColor.MapColor132,
            MapColor.MapColor133,
            MapColor.MapColor134,
            MapColor.MapColor135,
            MapColor.MapColor136,
            MapColor.MapColor137,
            MapColor.MapColor138,
            MapColor.MapColor139,
            MapColor.MapColor140,
            MapColor.MapColor141,
            MapColor.MapColor142,
            MapColor.MapColor143,
            MapColor.MapColor144,
            MapColor.MapColor145,
            MapColor.MapColor146,
            MapColor.MapColor147,
            MapColor.MapColor148,
            MapColor.MapColor149,
            MapColor.MapColor150,
            MapColor.MapColor151,
            MapColor.MapColor152,
            MapColor.MapColor153,
            MapColor.MapColor154,
            MapColor.MapColor155,
            MapColor.MapColor156,
            MapColor.MapColor157,
            MapColor.MapColor158,
            MapColor.MapColor159,
            MapColor.MapColor160,
            MapColor.MapColor161,
            MapColor.MapColor162,
            MapColor.MapColor163,
            MapColor.MapColor164,
            MapColor.MapColor165,
            MapColor.MapColor166,
            MapColor.MapColor167,
            MapColor.MapColor168,
            MapColor.MapColor169,
            MapColor.MapColor170,
            MapColor.MapColor171,
            MapColor.MapColor172,
            MapColor.MapColor173,
            MapColor.MapColor174,
            MapColor.MapColor175,
            MapColor.MapColor176,
            MapColor.MapColor177,
            MapColor.MapColor178,
            MapColor.MapColor179,
            MapColor.MapColor180,
            MapColor.MapColor181,
            MapColor.MapColor182,
            MapColor.MapColor183,
            MapColor.MapColor184,
            MapColor.MapColor185,
            MapColor.MapColor186,
            MapColor.MapColor187,
            MapColor.MapColor188,
            MapColor.MapColor189,
            MapColor.MapColor190,
            MapColor.MapColor191,
            MapColor.MapColor192,
            MapColor.MapColor193,
            MapColor.MapColor194,
            MapColor.MapColor195,
            MapColor.MapColor196,
            MapColor.MapColor197,
            MapColor.MapColor198,
            MapColor.MapColor199,
            MapColor.MapColor200,
            MapColor.MapColor201,
            MapColor.MapColor202,
            MapColor.MapColor203,
            MapColor.MapColor204,
            MapColor.MapColor205,
            MapColor.MapColor206,
            MapColor.MapColor207,
            MapColor.MapColor208,
            MapColor.MapColor209,
            MapColor.MapColor210,
            MapColor.MapColor211,
            MapColor.MapColor212,
            MapColor.MapColor213,
            MapColor.MapColor214,
            MapColor.MapColor215,
            MapColor.MapColor216,
            MapColor.MapColor217,
            MapColor.MapColor218,
            MapColor.MapColor219,
            MapColor.MapColor220,
            MapColor.MapColor221,
            MapColor.MapColor222,
            MapColor.MapColor223,
            MapColor.MapColor224,
            MapColor.MapColor225,
            MapColor.MapColor226,
            MapColor.MapColor227,
            MapColor.MapColor228,
            MapColor.MapColor229,
            MapColor.MapColor230,
            MapColor.MapColor231,
            MapColor.MapColor232,
            MapColor.MapColor233,
            MapColor.MapColor234,
            MapColor.MapColor235,
            MapColor.MapColor236,
            MapColor.MapColor237,
            MapColor.MapColor238,
            MapColor.MapColor239,
            MapColor.MapColor240,
            MapColor.MapColor241,
            MapColor.MapColor242,
            MapColor.MapColor243,
            MapColor.MapColor244,
            MapColor.MapColor245,
            MapColor.MapColor246,
            MapColor.MapColor247
        };
        #endregion
        #region MapHeader
        public static readonly byte[] MapHeader = new byte[173]
        {
            10,
            0,
            0,
            10,
            0,
            4,
            100,
            97,
            116,
            97,
            3,
            0,
            7,
            122,
            67,
            101,
            110,
            116,
            101,
            114,
            0,
            0,
            0,
            0,
            1,
            0,
            17,
            117,
            110,
            108,
            105,
            109,
            105,
            116,
            101,
            100,
            84,
            114,
            97,
            99,
            107,
            105,
            110,
            103,
            0,
            1,
            0,
            16,
            116,
            114,
            97,
            99,
            107,
            105,
            110,
            103,
            80,
            111,
            115,
            105,
            116,
            105,
            111,
            110,
            0,
            9,
            0,
            6,
            102,
            114,
            97,
            109,
            101,
            115,
            1,
            0,
            0,
            0,
            0,
            1,
            0,
            5,
            115,
            99,
            97,
            108,
            101,
            0,
            1,
            0,
            6,
            108,
            111,
            99,
            107,
            101,
            100,
            1,
            8,
            0,
            9,
            100,
            105,
            109,
            101,
            110,
            115,
            105,
            111,
            110,
            0,
            19,
            109,
            105,
            110,
            101,
            99,
            114,
            97,
            102,
            116,
            58,
            111,
            118,
            101,
            114,
            119,
            111,
            114,
            108,
            100,
            9,
            0,
            7,
            98,
            97,
            110,
            110,
            101,
            114,
            115,
            1,
            0,
            0,
            0,
            0,
            3,
            0,
            7,
            120,
            67,
            101,
            110,
            116,
            101,
            114,
            0,
            0,
            0,
            0,
            7,
            0,
            6,
            99,
            111,
            108,
            111,
            114,
            115,
            0,
            0,
            64,
            0
        };
        #endregion
        #region MapFooter
        public static readonly byte[] MapFooter = new byte[20]
        {
            0,
            3,
            0,
            11,
            68,
            97,
            116,
            97,
            86,
            101,
            114,
            115,
            105,
            111,
            110,
            0,
            0,
            12,
            48,
            0
        };
        #endregion
        public static void ImageToMap(string sourceImageFilePath, string mapsDirectoryPath, int mapID)
        {
            if (sourceImageFilePath is null)
            {
                throw new System.Exception("sourceImageFilePath cannot be null.");
            }
            if (sourceImageFilePath is "")
            {
                throw new System.Exception("sourceImageFilePath cannot be empty.");
            }
            if (!System.IO.File.Exists(sourceImageFilePath))
            {
                throw new System.Exception("No file exists at sourceImageFilePath.");
            }
            System.Drawing.Bitmap sourceImage;
            try
            {
                sourceImage = new System.Drawing.Bitmap(sourceImageFilePath);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Failed to load image from sourceImageFilePath.");
            }
            sourceImage = new System.Drawing.Bitmap(sourceImage, 128, 128);
            if (sourceImage.Width != 128)
            {
                throw new System.Exception("sourceImage.Width must be 128.");
            }
            if (sourceImage.Height != 128)
            {
                throw new System.Exception("sourceImage.Height must be 128.");
            }
            if (mapsDirectoryPath is null)
            {
                throw new System.Exception("mapsDirectoryPath cannot be null.");
            }
            if (mapsDirectoryPath is "")
            {
                throw new System.Exception("mapsDirectoryPath cannot be empty.");
            }
            if (!System.IO.Directory.Exists(mapsDirectoryPath))
            {
                throw new System.Exception("No directory exists at mapsDirectoryPath.");
            }
            if (mapID < 0)
            {
                throw new System.Exception("mapID must be greater than or equal to 0.");
            }
            string outputMapFilePath = $"{mapsDirectoryPath}\\map_{mapID}.dat";
            System.IO.FileStream outputMapFileStream;
            try
            {
                outputMapFileStream = System.IO.File.Open(outputMapFilePath, System.IO.FileMode.CreateNew, System.IO.FileAccess.Write, System.IO.FileShare.None);
            }
            catch
            {
                throw new System.Exception($"A map with id {mapID} already exists.");
            }
            byte[] uncompressedOutputData = new byte[16577];
            System.Array.Copy(MapHeader, 0, uncompressedOutputData, 0, 173);
            System.Array.Copy(MapFooter, 0, uncompressedOutputData, 16557, 20);
            int i = 173;
            for (int y = 0; y < 128; y++)
            {
                for (int x = 0; x < 128; x++)
                {
                    System.Drawing.Color bitmapPixelColor = sourceImage.GetPixel(x, y);
                    if (bitmapPixelColor.A < 128)
                    {
                        uncompressedOutputData[i] = 0;
                    }
                    else
                    {
                        int bestMatchDifference = int.MaxValue;
                        MapColor bestMatch = null;
                        foreach (MapColor mapColor in OpaqueMapColors)
                        {
                            int differenceR = mapColor.R - bitmapPixelColor.R;
                            if (differenceR < 0)
                            {
                                differenceR = -differenceR;
                            }
                            int differenceG = mapColor.G - bitmapPixelColor.G;
                            if (differenceG < 0)
                            {
                                differenceG = -differenceG;
                            }
                            int differenceB = mapColor.B - bitmapPixelColor.B;
                            if (differenceB < 0)
                            {
                                differenceB = -differenceB;
                            }
                            int difference = differenceR + differenceG + differenceB;
                            if (difference < bestMatchDifference)
                            {
                                bestMatch = mapColor;
                                bestMatchDifference = difference;
                            }
                        }
                        uncompressedOutputData[i] = bestMatch.ID;
                    }
                    i++;
                }
            }
            System.IO.MemoryStream compressedOutputDataStream = new System.IO.MemoryStream();
            System.IO.Compression.GZipStream gzipStream = new System.IO.Compression.GZipStream(compressedOutputDataStream, System.IO.Compression.CompressionMode.Compress);
            gzipStream.Write(uncompressedOutputData, 0, uncompressedOutputData.Length);
            gzipStream.Close();
            gzipStream.Dispose();
            byte[] compressedOutputData = compressedOutputDataStream.ToArray();
            compressedOutputDataStream.Close();
            compressedOutputDataStream.Dispose();
            outputMapFileStream.Write(compressedOutputData, 0, compressedOutputData.Length);
            outputMapFileStream.Close();
            outputMapFileStream.Dispose();
        }
    }
}
