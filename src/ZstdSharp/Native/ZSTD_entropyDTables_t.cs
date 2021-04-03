using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ZstdSharp
{
    public unsafe partial struct ZSTD_entropyDTables_t
    {
        /* Note : Space reserved for FSE Tables */
        public _LLTable_e__FixedBuffer LLTable;

        /* is also used as temporary workspace while building hufTable during DDict creation */
        public _OFTable_e__FixedBuffer OFTable;

        /* and therefore must be at least HUF_DECOMPRESS_WORKSPACE_SIZE large */
        public _MLTable_e__FixedBuffer MLTable;

        /* can accommodate HUF_decompress4X */
        public fixed uint hufTable[4097];

        public fixed uint rep[3];

        public fixed uint workspace[157];

        public unsafe partial struct _LLTable_e__FixedBuffer
        {
            public ZSTD_seqSymbol e0;
            public ZSTD_seqSymbol e1;
            public ZSTD_seqSymbol e2;
            public ZSTD_seqSymbol e3;
            public ZSTD_seqSymbol e4;
            public ZSTD_seqSymbol e5;
            public ZSTD_seqSymbol e6;
            public ZSTD_seqSymbol e7;
            public ZSTD_seqSymbol e8;
            public ZSTD_seqSymbol e9;
            public ZSTD_seqSymbol e10;
            public ZSTD_seqSymbol e11;
            public ZSTD_seqSymbol e12;
            public ZSTD_seqSymbol e13;
            public ZSTD_seqSymbol e14;
            public ZSTD_seqSymbol e15;
            public ZSTD_seqSymbol e16;
            public ZSTD_seqSymbol e17;
            public ZSTD_seqSymbol e18;
            public ZSTD_seqSymbol e19;
            public ZSTD_seqSymbol e20;
            public ZSTD_seqSymbol e21;
            public ZSTD_seqSymbol e22;
            public ZSTD_seqSymbol e23;
            public ZSTD_seqSymbol e24;
            public ZSTD_seqSymbol e25;
            public ZSTD_seqSymbol e26;
            public ZSTD_seqSymbol e27;
            public ZSTD_seqSymbol e28;
            public ZSTD_seqSymbol e29;
            public ZSTD_seqSymbol e30;
            public ZSTD_seqSymbol e31;
            public ZSTD_seqSymbol e32;
            public ZSTD_seqSymbol e33;
            public ZSTD_seqSymbol e34;
            public ZSTD_seqSymbol e35;
            public ZSTD_seqSymbol e36;
            public ZSTD_seqSymbol e37;
            public ZSTD_seqSymbol e38;
            public ZSTD_seqSymbol e39;
            public ZSTD_seqSymbol e40;
            public ZSTD_seqSymbol e41;
            public ZSTD_seqSymbol e42;
            public ZSTD_seqSymbol e43;
            public ZSTD_seqSymbol e44;
            public ZSTD_seqSymbol e45;
            public ZSTD_seqSymbol e46;
            public ZSTD_seqSymbol e47;
            public ZSTD_seqSymbol e48;
            public ZSTD_seqSymbol e49;
            public ZSTD_seqSymbol e50;
            public ZSTD_seqSymbol e51;
            public ZSTD_seqSymbol e52;
            public ZSTD_seqSymbol e53;
            public ZSTD_seqSymbol e54;
            public ZSTD_seqSymbol e55;
            public ZSTD_seqSymbol e56;
            public ZSTD_seqSymbol e57;
            public ZSTD_seqSymbol e58;
            public ZSTD_seqSymbol e59;
            public ZSTD_seqSymbol e60;
            public ZSTD_seqSymbol e61;
            public ZSTD_seqSymbol e62;
            public ZSTD_seqSymbol e63;
            public ZSTD_seqSymbol e64;
            public ZSTD_seqSymbol e65;
            public ZSTD_seqSymbol e66;
            public ZSTD_seqSymbol e67;
            public ZSTD_seqSymbol e68;
            public ZSTD_seqSymbol e69;
            public ZSTD_seqSymbol e70;
            public ZSTD_seqSymbol e71;
            public ZSTD_seqSymbol e72;
            public ZSTD_seqSymbol e73;
            public ZSTD_seqSymbol e74;
            public ZSTD_seqSymbol e75;
            public ZSTD_seqSymbol e76;
            public ZSTD_seqSymbol e77;
            public ZSTD_seqSymbol e78;
            public ZSTD_seqSymbol e79;
            public ZSTD_seqSymbol e80;
            public ZSTD_seqSymbol e81;
            public ZSTD_seqSymbol e82;
            public ZSTD_seqSymbol e83;
            public ZSTD_seqSymbol e84;
            public ZSTD_seqSymbol e85;
            public ZSTD_seqSymbol e86;
            public ZSTD_seqSymbol e87;
            public ZSTD_seqSymbol e88;
            public ZSTD_seqSymbol e89;
            public ZSTD_seqSymbol e90;
            public ZSTD_seqSymbol e91;
            public ZSTD_seqSymbol e92;
            public ZSTD_seqSymbol e93;
            public ZSTD_seqSymbol e94;
            public ZSTD_seqSymbol e95;
            public ZSTD_seqSymbol e96;
            public ZSTD_seqSymbol e97;
            public ZSTD_seqSymbol e98;
            public ZSTD_seqSymbol e99;
            public ZSTD_seqSymbol e100;
            public ZSTD_seqSymbol e101;
            public ZSTD_seqSymbol e102;
            public ZSTD_seqSymbol e103;
            public ZSTD_seqSymbol e104;
            public ZSTD_seqSymbol e105;
            public ZSTD_seqSymbol e106;
            public ZSTD_seqSymbol e107;
            public ZSTD_seqSymbol e108;
            public ZSTD_seqSymbol e109;
            public ZSTD_seqSymbol e110;
            public ZSTD_seqSymbol e111;
            public ZSTD_seqSymbol e112;
            public ZSTD_seqSymbol e113;
            public ZSTD_seqSymbol e114;
            public ZSTD_seqSymbol e115;
            public ZSTD_seqSymbol e116;
            public ZSTD_seqSymbol e117;
            public ZSTD_seqSymbol e118;
            public ZSTD_seqSymbol e119;
            public ZSTD_seqSymbol e120;
            public ZSTD_seqSymbol e121;
            public ZSTD_seqSymbol e122;
            public ZSTD_seqSymbol e123;
            public ZSTD_seqSymbol e124;
            public ZSTD_seqSymbol e125;
            public ZSTD_seqSymbol e126;
            public ZSTD_seqSymbol e127;
            public ZSTD_seqSymbol e128;
            public ZSTD_seqSymbol e129;
            public ZSTD_seqSymbol e130;
            public ZSTD_seqSymbol e131;
            public ZSTD_seqSymbol e132;
            public ZSTD_seqSymbol e133;
            public ZSTD_seqSymbol e134;
            public ZSTD_seqSymbol e135;
            public ZSTD_seqSymbol e136;
            public ZSTD_seqSymbol e137;
            public ZSTD_seqSymbol e138;
            public ZSTD_seqSymbol e139;
            public ZSTD_seqSymbol e140;
            public ZSTD_seqSymbol e141;
            public ZSTD_seqSymbol e142;
            public ZSTD_seqSymbol e143;
            public ZSTD_seqSymbol e144;
            public ZSTD_seqSymbol e145;
            public ZSTD_seqSymbol e146;
            public ZSTD_seqSymbol e147;
            public ZSTD_seqSymbol e148;
            public ZSTD_seqSymbol e149;
            public ZSTD_seqSymbol e150;
            public ZSTD_seqSymbol e151;
            public ZSTD_seqSymbol e152;
            public ZSTD_seqSymbol e153;
            public ZSTD_seqSymbol e154;
            public ZSTD_seqSymbol e155;
            public ZSTD_seqSymbol e156;
            public ZSTD_seqSymbol e157;
            public ZSTD_seqSymbol e158;
            public ZSTD_seqSymbol e159;
            public ZSTD_seqSymbol e160;
            public ZSTD_seqSymbol e161;
            public ZSTD_seqSymbol e162;
            public ZSTD_seqSymbol e163;
            public ZSTD_seqSymbol e164;
            public ZSTD_seqSymbol e165;
            public ZSTD_seqSymbol e166;
            public ZSTD_seqSymbol e167;
            public ZSTD_seqSymbol e168;
            public ZSTD_seqSymbol e169;
            public ZSTD_seqSymbol e170;
            public ZSTD_seqSymbol e171;
            public ZSTD_seqSymbol e172;
            public ZSTD_seqSymbol e173;
            public ZSTD_seqSymbol e174;
            public ZSTD_seqSymbol e175;
            public ZSTD_seqSymbol e176;
            public ZSTD_seqSymbol e177;
            public ZSTD_seqSymbol e178;
            public ZSTD_seqSymbol e179;
            public ZSTD_seqSymbol e180;
            public ZSTD_seqSymbol e181;
            public ZSTD_seqSymbol e182;
            public ZSTD_seqSymbol e183;
            public ZSTD_seqSymbol e184;
            public ZSTD_seqSymbol e185;
            public ZSTD_seqSymbol e186;
            public ZSTD_seqSymbol e187;
            public ZSTD_seqSymbol e188;
            public ZSTD_seqSymbol e189;
            public ZSTD_seqSymbol e190;
            public ZSTD_seqSymbol e191;
            public ZSTD_seqSymbol e192;
            public ZSTD_seqSymbol e193;
            public ZSTD_seqSymbol e194;
            public ZSTD_seqSymbol e195;
            public ZSTD_seqSymbol e196;
            public ZSTD_seqSymbol e197;
            public ZSTD_seqSymbol e198;
            public ZSTD_seqSymbol e199;
            public ZSTD_seqSymbol e200;
            public ZSTD_seqSymbol e201;
            public ZSTD_seqSymbol e202;
            public ZSTD_seqSymbol e203;
            public ZSTD_seqSymbol e204;
            public ZSTD_seqSymbol e205;
            public ZSTD_seqSymbol e206;
            public ZSTD_seqSymbol e207;
            public ZSTD_seqSymbol e208;
            public ZSTD_seqSymbol e209;
            public ZSTD_seqSymbol e210;
            public ZSTD_seqSymbol e211;
            public ZSTD_seqSymbol e212;
            public ZSTD_seqSymbol e213;
            public ZSTD_seqSymbol e214;
            public ZSTD_seqSymbol e215;
            public ZSTD_seqSymbol e216;
            public ZSTD_seqSymbol e217;
            public ZSTD_seqSymbol e218;
            public ZSTD_seqSymbol e219;
            public ZSTD_seqSymbol e220;
            public ZSTD_seqSymbol e221;
            public ZSTD_seqSymbol e222;
            public ZSTD_seqSymbol e223;
            public ZSTD_seqSymbol e224;
            public ZSTD_seqSymbol e225;
            public ZSTD_seqSymbol e226;
            public ZSTD_seqSymbol e227;
            public ZSTD_seqSymbol e228;
            public ZSTD_seqSymbol e229;
            public ZSTD_seqSymbol e230;
            public ZSTD_seqSymbol e231;
            public ZSTD_seqSymbol e232;
            public ZSTD_seqSymbol e233;
            public ZSTD_seqSymbol e234;
            public ZSTD_seqSymbol e235;
            public ZSTD_seqSymbol e236;
            public ZSTD_seqSymbol e237;
            public ZSTD_seqSymbol e238;
            public ZSTD_seqSymbol e239;
            public ZSTD_seqSymbol e240;
            public ZSTD_seqSymbol e241;
            public ZSTD_seqSymbol e242;
            public ZSTD_seqSymbol e243;
            public ZSTD_seqSymbol e244;
            public ZSTD_seqSymbol e245;
            public ZSTD_seqSymbol e246;
            public ZSTD_seqSymbol e247;
            public ZSTD_seqSymbol e248;
            public ZSTD_seqSymbol e249;
            public ZSTD_seqSymbol e250;
            public ZSTD_seqSymbol e251;
            public ZSTD_seqSymbol e252;
            public ZSTD_seqSymbol e253;
            public ZSTD_seqSymbol e254;
            public ZSTD_seqSymbol e255;
            public ZSTD_seqSymbol e256;
            public ZSTD_seqSymbol e257;
            public ZSTD_seqSymbol e258;
            public ZSTD_seqSymbol e259;
            public ZSTD_seqSymbol e260;
            public ZSTD_seqSymbol e261;
            public ZSTD_seqSymbol e262;
            public ZSTD_seqSymbol e263;
            public ZSTD_seqSymbol e264;
            public ZSTD_seqSymbol e265;
            public ZSTD_seqSymbol e266;
            public ZSTD_seqSymbol e267;
            public ZSTD_seqSymbol e268;
            public ZSTD_seqSymbol e269;
            public ZSTD_seqSymbol e270;
            public ZSTD_seqSymbol e271;
            public ZSTD_seqSymbol e272;
            public ZSTD_seqSymbol e273;
            public ZSTD_seqSymbol e274;
            public ZSTD_seqSymbol e275;
            public ZSTD_seqSymbol e276;
            public ZSTD_seqSymbol e277;
            public ZSTD_seqSymbol e278;
            public ZSTD_seqSymbol e279;
            public ZSTD_seqSymbol e280;
            public ZSTD_seqSymbol e281;
            public ZSTD_seqSymbol e282;
            public ZSTD_seqSymbol e283;
            public ZSTD_seqSymbol e284;
            public ZSTD_seqSymbol e285;
            public ZSTD_seqSymbol e286;
            public ZSTD_seqSymbol e287;
            public ZSTD_seqSymbol e288;
            public ZSTD_seqSymbol e289;
            public ZSTD_seqSymbol e290;
            public ZSTD_seqSymbol e291;
            public ZSTD_seqSymbol e292;
            public ZSTD_seqSymbol e293;
            public ZSTD_seqSymbol e294;
            public ZSTD_seqSymbol e295;
            public ZSTD_seqSymbol e296;
            public ZSTD_seqSymbol e297;
            public ZSTD_seqSymbol e298;
            public ZSTD_seqSymbol e299;
            public ZSTD_seqSymbol e300;
            public ZSTD_seqSymbol e301;
            public ZSTD_seqSymbol e302;
            public ZSTD_seqSymbol e303;
            public ZSTD_seqSymbol e304;
            public ZSTD_seqSymbol e305;
            public ZSTD_seqSymbol e306;
            public ZSTD_seqSymbol e307;
            public ZSTD_seqSymbol e308;
            public ZSTD_seqSymbol e309;
            public ZSTD_seqSymbol e310;
            public ZSTD_seqSymbol e311;
            public ZSTD_seqSymbol e312;
            public ZSTD_seqSymbol e313;
            public ZSTD_seqSymbol e314;
            public ZSTD_seqSymbol e315;
            public ZSTD_seqSymbol e316;
            public ZSTD_seqSymbol e317;
            public ZSTD_seqSymbol e318;
            public ZSTD_seqSymbol e319;
            public ZSTD_seqSymbol e320;
            public ZSTD_seqSymbol e321;
            public ZSTD_seqSymbol e322;
            public ZSTD_seqSymbol e323;
            public ZSTD_seqSymbol e324;
            public ZSTD_seqSymbol e325;
            public ZSTD_seqSymbol e326;
            public ZSTD_seqSymbol e327;
            public ZSTD_seqSymbol e328;
            public ZSTD_seqSymbol e329;
            public ZSTD_seqSymbol e330;
            public ZSTD_seqSymbol e331;
            public ZSTD_seqSymbol e332;
            public ZSTD_seqSymbol e333;
            public ZSTD_seqSymbol e334;
            public ZSTD_seqSymbol e335;
            public ZSTD_seqSymbol e336;
            public ZSTD_seqSymbol e337;
            public ZSTD_seqSymbol e338;
            public ZSTD_seqSymbol e339;
            public ZSTD_seqSymbol e340;
            public ZSTD_seqSymbol e341;
            public ZSTD_seqSymbol e342;
            public ZSTD_seqSymbol e343;
            public ZSTD_seqSymbol e344;
            public ZSTD_seqSymbol e345;
            public ZSTD_seqSymbol e346;
            public ZSTD_seqSymbol e347;
            public ZSTD_seqSymbol e348;
            public ZSTD_seqSymbol e349;
            public ZSTD_seqSymbol e350;
            public ZSTD_seqSymbol e351;
            public ZSTD_seqSymbol e352;
            public ZSTD_seqSymbol e353;
            public ZSTD_seqSymbol e354;
            public ZSTD_seqSymbol e355;
            public ZSTD_seqSymbol e356;
            public ZSTD_seqSymbol e357;
            public ZSTD_seqSymbol e358;
            public ZSTD_seqSymbol e359;
            public ZSTD_seqSymbol e360;
            public ZSTD_seqSymbol e361;
            public ZSTD_seqSymbol e362;
            public ZSTD_seqSymbol e363;
            public ZSTD_seqSymbol e364;
            public ZSTD_seqSymbol e365;
            public ZSTD_seqSymbol e366;
            public ZSTD_seqSymbol e367;
            public ZSTD_seqSymbol e368;
            public ZSTD_seqSymbol e369;
            public ZSTD_seqSymbol e370;
            public ZSTD_seqSymbol e371;
            public ZSTD_seqSymbol e372;
            public ZSTD_seqSymbol e373;
            public ZSTD_seqSymbol e374;
            public ZSTD_seqSymbol e375;
            public ZSTD_seqSymbol e376;
            public ZSTD_seqSymbol e377;
            public ZSTD_seqSymbol e378;
            public ZSTD_seqSymbol e379;
            public ZSTD_seqSymbol e380;
            public ZSTD_seqSymbol e381;
            public ZSTD_seqSymbol e382;
            public ZSTD_seqSymbol e383;
            public ZSTD_seqSymbol e384;
            public ZSTD_seqSymbol e385;
            public ZSTD_seqSymbol e386;
            public ZSTD_seqSymbol e387;
            public ZSTD_seqSymbol e388;
            public ZSTD_seqSymbol e389;
            public ZSTD_seqSymbol e390;
            public ZSTD_seqSymbol e391;
            public ZSTD_seqSymbol e392;
            public ZSTD_seqSymbol e393;
            public ZSTD_seqSymbol e394;
            public ZSTD_seqSymbol e395;
            public ZSTD_seqSymbol e396;
            public ZSTD_seqSymbol e397;
            public ZSTD_seqSymbol e398;
            public ZSTD_seqSymbol e399;
            public ZSTD_seqSymbol e400;
            public ZSTD_seqSymbol e401;
            public ZSTD_seqSymbol e402;
            public ZSTD_seqSymbol e403;
            public ZSTD_seqSymbol e404;
            public ZSTD_seqSymbol e405;
            public ZSTD_seqSymbol e406;
            public ZSTD_seqSymbol e407;
            public ZSTD_seqSymbol e408;
            public ZSTD_seqSymbol e409;
            public ZSTD_seqSymbol e410;
            public ZSTD_seqSymbol e411;
            public ZSTD_seqSymbol e412;
            public ZSTD_seqSymbol e413;
            public ZSTD_seqSymbol e414;
            public ZSTD_seqSymbol e415;
            public ZSTD_seqSymbol e416;
            public ZSTD_seqSymbol e417;
            public ZSTD_seqSymbol e418;
            public ZSTD_seqSymbol e419;
            public ZSTD_seqSymbol e420;
            public ZSTD_seqSymbol e421;
            public ZSTD_seqSymbol e422;
            public ZSTD_seqSymbol e423;
            public ZSTD_seqSymbol e424;
            public ZSTD_seqSymbol e425;
            public ZSTD_seqSymbol e426;
            public ZSTD_seqSymbol e427;
            public ZSTD_seqSymbol e428;
            public ZSTD_seqSymbol e429;
            public ZSTD_seqSymbol e430;
            public ZSTD_seqSymbol e431;
            public ZSTD_seqSymbol e432;
            public ZSTD_seqSymbol e433;
            public ZSTD_seqSymbol e434;
            public ZSTD_seqSymbol e435;
            public ZSTD_seqSymbol e436;
            public ZSTD_seqSymbol e437;
            public ZSTD_seqSymbol e438;
            public ZSTD_seqSymbol e439;
            public ZSTD_seqSymbol e440;
            public ZSTD_seqSymbol e441;
            public ZSTD_seqSymbol e442;
            public ZSTD_seqSymbol e443;
            public ZSTD_seqSymbol e444;
            public ZSTD_seqSymbol e445;
            public ZSTD_seqSymbol e446;
            public ZSTD_seqSymbol e447;
            public ZSTD_seqSymbol e448;
            public ZSTD_seqSymbol e449;
            public ZSTD_seqSymbol e450;
            public ZSTD_seqSymbol e451;
            public ZSTD_seqSymbol e452;
            public ZSTD_seqSymbol e453;
            public ZSTD_seqSymbol e454;
            public ZSTD_seqSymbol e455;
            public ZSTD_seqSymbol e456;
            public ZSTD_seqSymbol e457;
            public ZSTD_seqSymbol e458;
            public ZSTD_seqSymbol e459;
            public ZSTD_seqSymbol e460;
            public ZSTD_seqSymbol e461;
            public ZSTD_seqSymbol e462;
            public ZSTD_seqSymbol e463;
            public ZSTD_seqSymbol e464;
            public ZSTD_seqSymbol e465;
            public ZSTD_seqSymbol e466;
            public ZSTD_seqSymbol e467;
            public ZSTD_seqSymbol e468;
            public ZSTD_seqSymbol e469;
            public ZSTD_seqSymbol e470;
            public ZSTD_seqSymbol e471;
            public ZSTD_seqSymbol e472;
            public ZSTD_seqSymbol e473;
            public ZSTD_seqSymbol e474;
            public ZSTD_seqSymbol e475;
            public ZSTD_seqSymbol e476;
            public ZSTD_seqSymbol e477;
            public ZSTD_seqSymbol e478;
            public ZSTD_seqSymbol e479;
            public ZSTD_seqSymbol e480;
            public ZSTD_seqSymbol e481;
            public ZSTD_seqSymbol e482;
            public ZSTD_seqSymbol e483;
            public ZSTD_seqSymbol e484;
            public ZSTD_seqSymbol e485;
            public ZSTD_seqSymbol e486;
            public ZSTD_seqSymbol e487;
            public ZSTD_seqSymbol e488;
            public ZSTD_seqSymbol e489;
            public ZSTD_seqSymbol e490;
            public ZSTD_seqSymbol e491;
            public ZSTD_seqSymbol e492;
            public ZSTD_seqSymbol e493;
            public ZSTD_seqSymbol e494;
            public ZSTD_seqSymbol e495;
            public ZSTD_seqSymbol e496;
            public ZSTD_seqSymbol e497;
            public ZSTD_seqSymbol e498;
            public ZSTD_seqSymbol e499;
            public ZSTD_seqSymbol e500;
            public ZSTD_seqSymbol e501;
            public ZSTD_seqSymbol e502;
            public ZSTD_seqSymbol e503;
            public ZSTD_seqSymbol e504;
            public ZSTD_seqSymbol e505;
            public ZSTD_seqSymbol e506;
            public ZSTD_seqSymbol e507;
            public ZSTD_seqSymbol e508;
            public ZSTD_seqSymbol e509;
            public ZSTD_seqSymbol e510;
            public ZSTD_seqSymbol e511;
            public ZSTD_seqSymbol e512;

            public ref ZSTD_seqSymbol this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public Span<ZSTD_seqSymbol> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 513);

            public ref ZSTD_seqSymbol this[uint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get => ref AsSpan()[(int) index];
            }

            public ref ZSTD_seqSymbol this[nuint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get => ref AsSpan()[(int) index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public static implicit operator ZSTD_seqSymbol*(in _LLTable_e__FixedBuffer t)
            {
                fixed (ZSTD_seqSymbol *pThis = &t.e0)
                {
                    return pThis;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public static ZSTD_seqSymbol* operator +(in _LLTable_e__FixedBuffer t, uint index)
            {
                fixed (ZSTD_seqSymbol *pThis = &t.e0)
                {
                    return pThis + index;
                }
            }
        }

        public unsafe partial struct _OFTable_e__FixedBuffer
        {
            public ZSTD_seqSymbol e0;
            public ZSTD_seqSymbol e1;
            public ZSTD_seqSymbol e2;
            public ZSTD_seqSymbol e3;
            public ZSTD_seqSymbol e4;
            public ZSTD_seqSymbol e5;
            public ZSTD_seqSymbol e6;
            public ZSTD_seqSymbol e7;
            public ZSTD_seqSymbol e8;
            public ZSTD_seqSymbol e9;
            public ZSTD_seqSymbol e10;
            public ZSTD_seqSymbol e11;
            public ZSTD_seqSymbol e12;
            public ZSTD_seqSymbol e13;
            public ZSTD_seqSymbol e14;
            public ZSTD_seqSymbol e15;
            public ZSTD_seqSymbol e16;
            public ZSTD_seqSymbol e17;
            public ZSTD_seqSymbol e18;
            public ZSTD_seqSymbol e19;
            public ZSTD_seqSymbol e20;
            public ZSTD_seqSymbol e21;
            public ZSTD_seqSymbol e22;
            public ZSTD_seqSymbol e23;
            public ZSTD_seqSymbol e24;
            public ZSTD_seqSymbol e25;
            public ZSTD_seqSymbol e26;
            public ZSTD_seqSymbol e27;
            public ZSTD_seqSymbol e28;
            public ZSTD_seqSymbol e29;
            public ZSTD_seqSymbol e30;
            public ZSTD_seqSymbol e31;
            public ZSTD_seqSymbol e32;
            public ZSTD_seqSymbol e33;
            public ZSTD_seqSymbol e34;
            public ZSTD_seqSymbol e35;
            public ZSTD_seqSymbol e36;
            public ZSTD_seqSymbol e37;
            public ZSTD_seqSymbol e38;
            public ZSTD_seqSymbol e39;
            public ZSTD_seqSymbol e40;
            public ZSTD_seqSymbol e41;
            public ZSTD_seqSymbol e42;
            public ZSTD_seqSymbol e43;
            public ZSTD_seqSymbol e44;
            public ZSTD_seqSymbol e45;
            public ZSTD_seqSymbol e46;
            public ZSTD_seqSymbol e47;
            public ZSTD_seqSymbol e48;
            public ZSTD_seqSymbol e49;
            public ZSTD_seqSymbol e50;
            public ZSTD_seqSymbol e51;
            public ZSTD_seqSymbol e52;
            public ZSTD_seqSymbol e53;
            public ZSTD_seqSymbol e54;
            public ZSTD_seqSymbol e55;
            public ZSTD_seqSymbol e56;
            public ZSTD_seqSymbol e57;
            public ZSTD_seqSymbol e58;
            public ZSTD_seqSymbol e59;
            public ZSTD_seqSymbol e60;
            public ZSTD_seqSymbol e61;
            public ZSTD_seqSymbol e62;
            public ZSTD_seqSymbol e63;
            public ZSTD_seqSymbol e64;
            public ZSTD_seqSymbol e65;
            public ZSTD_seqSymbol e66;
            public ZSTD_seqSymbol e67;
            public ZSTD_seqSymbol e68;
            public ZSTD_seqSymbol e69;
            public ZSTD_seqSymbol e70;
            public ZSTD_seqSymbol e71;
            public ZSTD_seqSymbol e72;
            public ZSTD_seqSymbol e73;
            public ZSTD_seqSymbol e74;
            public ZSTD_seqSymbol e75;
            public ZSTD_seqSymbol e76;
            public ZSTD_seqSymbol e77;
            public ZSTD_seqSymbol e78;
            public ZSTD_seqSymbol e79;
            public ZSTD_seqSymbol e80;
            public ZSTD_seqSymbol e81;
            public ZSTD_seqSymbol e82;
            public ZSTD_seqSymbol e83;
            public ZSTD_seqSymbol e84;
            public ZSTD_seqSymbol e85;
            public ZSTD_seqSymbol e86;
            public ZSTD_seqSymbol e87;
            public ZSTD_seqSymbol e88;
            public ZSTD_seqSymbol e89;
            public ZSTD_seqSymbol e90;
            public ZSTD_seqSymbol e91;
            public ZSTD_seqSymbol e92;
            public ZSTD_seqSymbol e93;
            public ZSTD_seqSymbol e94;
            public ZSTD_seqSymbol e95;
            public ZSTD_seqSymbol e96;
            public ZSTD_seqSymbol e97;
            public ZSTD_seqSymbol e98;
            public ZSTD_seqSymbol e99;
            public ZSTD_seqSymbol e100;
            public ZSTD_seqSymbol e101;
            public ZSTD_seqSymbol e102;
            public ZSTD_seqSymbol e103;
            public ZSTD_seqSymbol e104;
            public ZSTD_seqSymbol e105;
            public ZSTD_seqSymbol e106;
            public ZSTD_seqSymbol e107;
            public ZSTD_seqSymbol e108;
            public ZSTD_seqSymbol e109;
            public ZSTD_seqSymbol e110;
            public ZSTD_seqSymbol e111;
            public ZSTD_seqSymbol e112;
            public ZSTD_seqSymbol e113;
            public ZSTD_seqSymbol e114;
            public ZSTD_seqSymbol e115;
            public ZSTD_seqSymbol e116;
            public ZSTD_seqSymbol e117;
            public ZSTD_seqSymbol e118;
            public ZSTD_seqSymbol e119;
            public ZSTD_seqSymbol e120;
            public ZSTD_seqSymbol e121;
            public ZSTD_seqSymbol e122;
            public ZSTD_seqSymbol e123;
            public ZSTD_seqSymbol e124;
            public ZSTD_seqSymbol e125;
            public ZSTD_seqSymbol e126;
            public ZSTD_seqSymbol e127;
            public ZSTD_seqSymbol e128;
            public ZSTD_seqSymbol e129;
            public ZSTD_seqSymbol e130;
            public ZSTD_seqSymbol e131;
            public ZSTD_seqSymbol e132;
            public ZSTD_seqSymbol e133;
            public ZSTD_seqSymbol e134;
            public ZSTD_seqSymbol e135;
            public ZSTD_seqSymbol e136;
            public ZSTD_seqSymbol e137;
            public ZSTD_seqSymbol e138;
            public ZSTD_seqSymbol e139;
            public ZSTD_seqSymbol e140;
            public ZSTD_seqSymbol e141;
            public ZSTD_seqSymbol e142;
            public ZSTD_seqSymbol e143;
            public ZSTD_seqSymbol e144;
            public ZSTD_seqSymbol e145;
            public ZSTD_seqSymbol e146;
            public ZSTD_seqSymbol e147;
            public ZSTD_seqSymbol e148;
            public ZSTD_seqSymbol e149;
            public ZSTD_seqSymbol e150;
            public ZSTD_seqSymbol e151;
            public ZSTD_seqSymbol e152;
            public ZSTD_seqSymbol e153;
            public ZSTD_seqSymbol e154;
            public ZSTD_seqSymbol e155;
            public ZSTD_seqSymbol e156;
            public ZSTD_seqSymbol e157;
            public ZSTD_seqSymbol e158;
            public ZSTD_seqSymbol e159;
            public ZSTD_seqSymbol e160;
            public ZSTD_seqSymbol e161;
            public ZSTD_seqSymbol e162;
            public ZSTD_seqSymbol e163;
            public ZSTD_seqSymbol e164;
            public ZSTD_seqSymbol e165;
            public ZSTD_seqSymbol e166;
            public ZSTD_seqSymbol e167;
            public ZSTD_seqSymbol e168;
            public ZSTD_seqSymbol e169;
            public ZSTD_seqSymbol e170;
            public ZSTD_seqSymbol e171;
            public ZSTD_seqSymbol e172;
            public ZSTD_seqSymbol e173;
            public ZSTD_seqSymbol e174;
            public ZSTD_seqSymbol e175;
            public ZSTD_seqSymbol e176;
            public ZSTD_seqSymbol e177;
            public ZSTD_seqSymbol e178;
            public ZSTD_seqSymbol e179;
            public ZSTD_seqSymbol e180;
            public ZSTD_seqSymbol e181;
            public ZSTD_seqSymbol e182;
            public ZSTD_seqSymbol e183;
            public ZSTD_seqSymbol e184;
            public ZSTD_seqSymbol e185;
            public ZSTD_seqSymbol e186;
            public ZSTD_seqSymbol e187;
            public ZSTD_seqSymbol e188;
            public ZSTD_seqSymbol e189;
            public ZSTD_seqSymbol e190;
            public ZSTD_seqSymbol e191;
            public ZSTD_seqSymbol e192;
            public ZSTD_seqSymbol e193;
            public ZSTD_seqSymbol e194;
            public ZSTD_seqSymbol e195;
            public ZSTD_seqSymbol e196;
            public ZSTD_seqSymbol e197;
            public ZSTD_seqSymbol e198;
            public ZSTD_seqSymbol e199;
            public ZSTD_seqSymbol e200;
            public ZSTD_seqSymbol e201;
            public ZSTD_seqSymbol e202;
            public ZSTD_seqSymbol e203;
            public ZSTD_seqSymbol e204;
            public ZSTD_seqSymbol e205;
            public ZSTD_seqSymbol e206;
            public ZSTD_seqSymbol e207;
            public ZSTD_seqSymbol e208;
            public ZSTD_seqSymbol e209;
            public ZSTD_seqSymbol e210;
            public ZSTD_seqSymbol e211;
            public ZSTD_seqSymbol e212;
            public ZSTD_seqSymbol e213;
            public ZSTD_seqSymbol e214;
            public ZSTD_seqSymbol e215;
            public ZSTD_seqSymbol e216;
            public ZSTD_seqSymbol e217;
            public ZSTD_seqSymbol e218;
            public ZSTD_seqSymbol e219;
            public ZSTD_seqSymbol e220;
            public ZSTD_seqSymbol e221;
            public ZSTD_seqSymbol e222;
            public ZSTD_seqSymbol e223;
            public ZSTD_seqSymbol e224;
            public ZSTD_seqSymbol e225;
            public ZSTD_seqSymbol e226;
            public ZSTD_seqSymbol e227;
            public ZSTD_seqSymbol e228;
            public ZSTD_seqSymbol e229;
            public ZSTD_seqSymbol e230;
            public ZSTD_seqSymbol e231;
            public ZSTD_seqSymbol e232;
            public ZSTD_seqSymbol e233;
            public ZSTD_seqSymbol e234;
            public ZSTD_seqSymbol e235;
            public ZSTD_seqSymbol e236;
            public ZSTD_seqSymbol e237;
            public ZSTD_seqSymbol e238;
            public ZSTD_seqSymbol e239;
            public ZSTD_seqSymbol e240;
            public ZSTD_seqSymbol e241;
            public ZSTD_seqSymbol e242;
            public ZSTD_seqSymbol e243;
            public ZSTD_seqSymbol e244;
            public ZSTD_seqSymbol e245;
            public ZSTD_seqSymbol e246;
            public ZSTD_seqSymbol e247;
            public ZSTD_seqSymbol e248;
            public ZSTD_seqSymbol e249;
            public ZSTD_seqSymbol e250;
            public ZSTD_seqSymbol e251;
            public ZSTD_seqSymbol e252;
            public ZSTD_seqSymbol e253;
            public ZSTD_seqSymbol e254;
            public ZSTD_seqSymbol e255;
            public ZSTD_seqSymbol e256;

            public ref ZSTD_seqSymbol this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public Span<ZSTD_seqSymbol> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 257);

            public ref ZSTD_seqSymbol this[uint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get => ref AsSpan()[(int) index];
            }

            public ref ZSTD_seqSymbol this[nuint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get => ref AsSpan()[(int) index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public static implicit operator ZSTD_seqSymbol*(in _OFTable_e__FixedBuffer t)
            {
                fixed (ZSTD_seqSymbol *pThis = &t.e0)
                {
                    return pThis;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public static ZSTD_seqSymbol* operator +(in _OFTable_e__FixedBuffer t, uint index)
            {
                fixed (ZSTD_seqSymbol *pThis = &t.e0)
                {
                    return pThis + index;
                }
            }
        }

        public unsafe partial struct _MLTable_e__FixedBuffer
        {
            public ZSTD_seqSymbol e0;
            public ZSTD_seqSymbol e1;
            public ZSTD_seqSymbol e2;
            public ZSTD_seqSymbol e3;
            public ZSTD_seqSymbol e4;
            public ZSTD_seqSymbol e5;
            public ZSTD_seqSymbol e6;
            public ZSTD_seqSymbol e7;
            public ZSTD_seqSymbol e8;
            public ZSTD_seqSymbol e9;
            public ZSTD_seqSymbol e10;
            public ZSTD_seqSymbol e11;
            public ZSTD_seqSymbol e12;
            public ZSTD_seqSymbol e13;
            public ZSTD_seqSymbol e14;
            public ZSTD_seqSymbol e15;
            public ZSTD_seqSymbol e16;
            public ZSTD_seqSymbol e17;
            public ZSTD_seqSymbol e18;
            public ZSTD_seqSymbol e19;
            public ZSTD_seqSymbol e20;
            public ZSTD_seqSymbol e21;
            public ZSTD_seqSymbol e22;
            public ZSTD_seqSymbol e23;
            public ZSTD_seqSymbol e24;
            public ZSTD_seqSymbol e25;
            public ZSTD_seqSymbol e26;
            public ZSTD_seqSymbol e27;
            public ZSTD_seqSymbol e28;
            public ZSTD_seqSymbol e29;
            public ZSTD_seqSymbol e30;
            public ZSTD_seqSymbol e31;
            public ZSTD_seqSymbol e32;
            public ZSTD_seqSymbol e33;
            public ZSTD_seqSymbol e34;
            public ZSTD_seqSymbol e35;
            public ZSTD_seqSymbol e36;
            public ZSTD_seqSymbol e37;
            public ZSTD_seqSymbol e38;
            public ZSTD_seqSymbol e39;
            public ZSTD_seqSymbol e40;
            public ZSTD_seqSymbol e41;
            public ZSTD_seqSymbol e42;
            public ZSTD_seqSymbol e43;
            public ZSTD_seqSymbol e44;
            public ZSTD_seqSymbol e45;
            public ZSTD_seqSymbol e46;
            public ZSTD_seqSymbol e47;
            public ZSTD_seqSymbol e48;
            public ZSTD_seqSymbol e49;
            public ZSTD_seqSymbol e50;
            public ZSTD_seqSymbol e51;
            public ZSTD_seqSymbol e52;
            public ZSTD_seqSymbol e53;
            public ZSTD_seqSymbol e54;
            public ZSTD_seqSymbol e55;
            public ZSTD_seqSymbol e56;
            public ZSTD_seqSymbol e57;
            public ZSTD_seqSymbol e58;
            public ZSTD_seqSymbol e59;
            public ZSTD_seqSymbol e60;
            public ZSTD_seqSymbol e61;
            public ZSTD_seqSymbol e62;
            public ZSTD_seqSymbol e63;
            public ZSTD_seqSymbol e64;
            public ZSTD_seqSymbol e65;
            public ZSTD_seqSymbol e66;
            public ZSTD_seqSymbol e67;
            public ZSTD_seqSymbol e68;
            public ZSTD_seqSymbol e69;
            public ZSTD_seqSymbol e70;
            public ZSTD_seqSymbol e71;
            public ZSTD_seqSymbol e72;
            public ZSTD_seqSymbol e73;
            public ZSTD_seqSymbol e74;
            public ZSTD_seqSymbol e75;
            public ZSTD_seqSymbol e76;
            public ZSTD_seqSymbol e77;
            public ZSTD_seqSymbol e78;
            public ZSTD_seqSymbol e79;
            public ZSTD_seqSymbol e80;
            public ZSTD_seqSymbol e81;
            public ZSTD_seqSymbol e82;
            public ZSTD_seqSymbol e83;
            public ZSTD_seqSymbol e84;
            public ZSTD_seqSymbol e85;
            public ZSTD_seqSymbol e86;
            public ZSTD_seqSymbol e87;
            public ZSTD_seqSymbol e88;
            public ZSTD_seqSymbol e89;
            public ZSTD_seqSymbol e90;
            public ZSTD_seqSymbol e91;
            public ZSTD_seqSymbol e92;
            public ZSTD_seqSymbol e93;
            public ZSTD_seqSymbol e94;
            public ZSTD_seqSymbol e95;
            public ZSTD_seqSymbol e96;
            public ZSTD_seqSymbol e97;
            public ZSTD_seqSymbol e98;
            public ZSTD_seqSymbol e99;
            public ZSTD_seqSymbol e100;
            public ZSTD_seqSymbol e101;
            public ZSTD_seqSymbol e102;
            public ZSTD_seqSymbol e103;
            public ZSTD_seqSymbol e104;
            public ZSTD_seqSymbol e105;
            public ZSTD_seqSymbol e106;
            public ZSTD_seqSymbol e107;
            public ZSTD_seqSymbol e108;
            public ZSTD_seqSymbol e109;
            public ZSTD_seqSymbol e110;
            public ZSTD_seqSymbol e111;
            public ZSTD_seqSymbol e112;
            public ZSTD_seqSymbol e113;
            public ZSTD_seqSymbol e114;
            public ZSTD_seqSymbol e115;
            public ZSTD_seqSymbol e116;
            public ZSTD_seqSymbol e117;
            public ZSTD_seqSymbol e118;
            public ZSTD_seqSymbol e119;
            public ZSTD_seqSymbol e120;
            public ZSTD_seqSymbol e121;
            public ZSTD_seqSymbol e122;
            public ZSTD_seqSymbol e123;
            public ZSTD_seqSymbol e124;
            public ZSTD_seqSymbol e125;
            public ZSTD_seqSymbol e126;
            public ZSTD_seqSymbol e127;
            public ZSTD_seqSymbol e128;
            public ZSTD_seqSymbol e129;
            public ZSTD_seqSymbol e130;
            public ZSTD_seqSymbol e131;
            public ZSTD_seqSymbol e132;
            public ZSTD_seqSymbol e133;
            public ZSTD_seqSymbol e134;
            public ZSTD_seqSymbol e135;
            public ZSTD_seqSymbol e136;
            public ZSTD_seqSymbol e137;
            public ZSTD_seqSymbol e138;
            public ZSTD_seqSymbol e139;
            public ZSTD_seqSymbol e140;
            public ZSTD_seqSymbol e141;
            public ZSTD_seqSymbol e142;
            public ZSTD_seqSymbol e143;
            public ZSTD_seqSymbol e144;
            public ZSTD_seqSymbol e145;
            public ZSTD_seqSymbol e146;
            public ZSTD_seqSymbol e147;
            public ZSTD_seqSymbol e148;
            public ZSTD_seqSymbol e149;
            public ZSTD_seqSymbol e150;
            public ZSTD_seqSymbol e151;
            public ZSTD_seqSymbol e152;
            public ZSTD_seqSymbol e153;
            public ZSTD_seqSymbol e154;
            public ZSTD_seqSymbol e155;
            public ZSTD_seqSymbol e156;
            public ZSTD_seqSymbol e157;
            public ZSTD_seqSymbol e158;
            public ZSTD_seqSymbol e159;
            public ZSTD_seqSymbol e160;
            public ZSTD_seqSymbol e161;
            public ZSTD_seqSymbol e162;
            public ZSTD_seqSymbol e163;
            public ZSTD_seqSymbol e164;
            public ZSTD_seqSymbol e165;
            public ZSTD_seqSymbol e166;
            public ZSTD_seqSymbol e167;
            public ZSTD_seqSymbol e168;
            public ZSTD_seqSymbol e169;
            public ZSTD_seqSymbol e170;
            public ZSTD_seqSymbol e171;
            public ZSTD_seqSymbol e172;
            public ZSTD_seqSymbol e173;
            public ZSTD_seqSymbol e174;
            public ZSTD_seqSymbol e175;
            public ZSTD_seqSymbol e176;
            public ZSTD_seqSymbol e177;
            public ZSTD_seqSymbol e178;
            public ZSTD_seqSymbol e179;
            public ZSTD_seqSymbol e180;
            public ZSTD_seqSymbol e181;
            public ZSTD_seqSymbol e182;
            public ZSTD_seqSymbol e183;
            public ZSTD_seqSymbol e184;
            public ZSTD_seqSymbol e185;
            public ZSTD_seqSymbol e186;
            public ZSTD_seqSymbol e187;
            public ZSTD_seqSymbol e188;
            public ZSTD_seqSymbol e189;
            public ZSTD_seqSymbol e190;
            public ZSTD_seqSymbol e191;
            public ZSTD_seqSymbol e192;
            public ZSTD_seqSymbol e193;
            public ZSTD_seqSymbol e194;
            public ZSTD_seqSymbol e195;
            public ZSTD_seqSymbol e196;
            public ZSTD_seqSymbol e197;
            public ZSTD_seqSymbol e198;
            public ZSTD_seqSymbol e199;
            public ZSTD_seqSymbol e200;
            public ZSTD_seqSymbol e201;
            public ZSTD_seqSymbol e202;
            public ZSTD_seqSymbol e203;
            public ZSTD_seqSymbol e204;
            public ZSTD_seqSymbol e205;
            public ZSTD_seqSymbol e206;
            public ZSTD_seqSymbol e207;
            public ZSTD_seqSymbol e208;
            public ZSTD_seqSymbol e209;
            public ZSTD_seqSymbol e210;
            public ZSTD_seqSymbol e211;
            public ZSTD_seqSymbol e212;
            public ZSTD_seqSymbol e213;
            public ZSTD_seqSymbol e214;
            public ZSTD_seqSymbol e215;
            public ZSTD_seqSymbol e216;
            public ZSTD_seqSymbol e217;
            public ZSTD_seqSymbol e218;
            public ZSTD_seqSymbol e219;
            public ZSTD_seqSymbol e220;
            public ZSTD_seqSymbol e221;
            public ZSTD_seqSymbol e222;
            public ZSTD_seqSymbol e223;
            public ZSTD_seqSymbol e224;
            public ZSTD_seqSymbol e225;
            public ZSTD_seqSymbol e226;
            public ZSTD_seqSymbol e227;
            public ZSTD_seqSymbol e228;
            public ZSTD_seqSymbol e229;
            public ZSTD_seqSymbol e230;
            public ZSTD_seqSymbol e231;
            public ZSTD_seqSymbol e232;
            public ZSTD_seqSymbol e233;
            public ZSTD_seqSymbol e234;
            public ZSTD_seqSymbol e235;
            public ZSTD_seqSymbol e236;
            public ZSTD_seqSymbol e237;
            public ZSTD_seqSymbol e238;
            public ZSTD_seqSymbol e239;
            public ZSTD_seqSymbol e240;
            public ZSTD_seqSymbol e241;
            public ZSTD_seqSymbol e242;
            public ZSTD_seqSymbol e243;
            public ZSTD_seqSymbol e244;
            public ZSTD_seqSymbol e245;
            public ZSTD_seqSymbol e246;
            public ZSTD_seqSymbol e247;
            public ZSTD_seqSymbol e248;
            public ZSTD_seqSymbol e249;
            public ZSTD_seqSymbol e250;
            public ZSTD_seqSymbol e251;
            public ZSTD_seqSymbol e252;
            public ZSTD_seqSymbol e253;
            public ZSTD_seqSymbol e254;
            public ZSTD_seqSymbol e255;
            public ZSTD_seqSymbol e256;
            public ZSTD_seqSymbol e257;
            public ZSTD_seqSymbol e258;
            public ZSTD_seqSymbol e259;
            public ZSTD_seqSymbol e260;
            public ZSTD_seqSymbol e261;
            public ZSTD_seqSymbol e262;
            public ZSTD_seqSymbol e263;
            public ZSTD_seqSymbol e264;
            public ZSTD_seqSymbol e265;
            public ZSTD_seqSymbol e266;
            public ZSTD_seqSymbol e267;
            public ZSTD_seqSymbol e268;
            public ZSTD_seqSymbol e269;
            public ZSTD_seqSymbol e270;
            public ZSTD_seqSymbol e271;
            public ZSTD_seqSymbol e272;
            public ZSTD_seqSymbol e273;
            public ZSTD_seqSymbol e274;
            public ZSTD_seqSymbol e275;
            public ZSTD_seqSymbol e276;
            public ZSTD_seqSymbol e277;
            public ZSTD_seqSymbol e278;
            public ZSTD_seqSymbol e279;
            public ZSTD_seqSymbol e280;
            public ZSTD_seqSymbol e281;
            public ZSTD_seqSymbol e282;
            public ZSTD_seqSymbol e283;
            public ZSTD_seqSymbol e284;
            public ZSTD_seqSymbol e285;
            public ZSTD_seqSymbol e286;
            public ZSTD_seqSymbol e287;
            public ZSTD_seqSymbol e288;
            public ZSTD_seqSymbol e289;
            public ZSTD_seqSymbol e290;
            public ZSTD_seqSymbol e291;
            public ZSTD_seqSymbol e292;
            public ZSTD_seqSymbol e293;
            public ZSTD_seqSymbol e294;
            public ZSTD_seqSymbol e295;
            public ZSTD_seqSymbol e296;
            public ZSTD_seqSymbol e297;
            public ZSTD_seqSymbol e298;
            public ZSTD_seqSymbol e299;
            public ZSTD_seqSymbol e300;
            public ZSTD_seqSymbol e301;
            public ZSTD_seqSymbol e302;
            public ZSTD_seqSymbol e303;
            public ZSTD_seqSymbol e304;
            public ZSTD_seqSymbol e305;
            public ZSTD_seqSymbol e306;
            public ZSTD_seqSymbol e307;
            public ZSTD_seqSymbol e308;
            public ZSTD_seqSymbol e309;
            public ZSTD_seqSymbol e310;
            public ZSTD_seqSymbol e311;
            public ZSTD_seqSymbol e312;
            public ZSTD_seqSymbol e313;
            public ZSTD_seqSymbol e314;
            public ZSTD_seqSymbol e315;
            public ZSTD_seqSymbol e316;
            public ZSTD_seqSymbol e317;
            public ZSTD_seqSymbol e318;
            public ZSTD_seqSymbol e319;
            public ZSTD_seqSymbol e320;
            public ZSTD_seqSymbol e321;
            public ZSTD_seqSymbol e322;
            public ZSTD_seqSymbol e323;
            public ZSTD_seqSymbol e324;
            public ZSTD_seqSymbol e325;
            public ZSTD_seqSymbol e326;
            public ZSTD_seqSymbol e327;
            public ZSTD_seqSymbol e328;
            public ZSTD_seqSymbol e329;
            public ZSTD_seqSymbol e330;
            public ZSTD_seqSymbol e331;
            public ZSTD_seqSymbol e332;
            public ZSTD_seqSymbol e333;
            public ZSTD_seqSymbol e334;
            public ZSTD_seqSymbol e335;
            public ZSTD_seqSymbol e336;
            public ZSTD_seqSymbol e337;
            public ZSTD_seqSymbol e338;
            public ZSTD_seqSymbol e339;
            public ZSTD_seqSymbol e340;
            public ZSTD_seqSymbol e341;
            public ZSTD_seqSymbol e342;
            public ZSTD_seqSymbol e343;
            public ZSTD_seqSymbol e344;
            public ZSTD_seqSymbol e345;
            public ZSTD_seqSymbol e346;
            public ZSTD_seqSymbol e347;
            public ZSTD_seqSymbol e348;
            public ZSTD_seqSymbol e349;
            public ZSTD_seqSymbol e350;
            public ZSTD_seqSymbol e351;
            public ZSTD_seqSymbol e352;
            public ZSTD_seqSymbol e353;
            public ZSTD_seqSymbol e354;
            public ZSTD_seqSymbol e355;
            public ZSTD_seqSymbol e356;
            public ZSTD_seqSymbol e357;
            public ZSTD_seqSymbol e358;
            public ZSTD_seqSymbol e359;
            public ZSTD_seqSymbol e360;
            public ZSTD_seqSymbol e361;
            public ZSTD_seqSymbol e362;
            public ZSTD_seqSymbol e363;
            public ZSTD_seqSymbol e364;
            public ZSTD_seqSymbol e365;
            public ZSTD_seqSymbol e366;
            public ZSTD_seqSymbol e367;
            public ZSTD_seqSymbol e368;
            public ZSTD_seqSymbol e369;
            public ZSTD_seqSymbol e370;
            public ZSTD_seqSymbol e371;
            public ZSTD_seqSymbol e372;
            public ZSTD_seqSymbol e373;
            public ZSTD_seqSymbol e374;
            public ZSTD_seqSymbol e375;
            public ZSTD_seqSymbol e376;
            public ZSTD_seqSymbol e377;
            public ZSTD_seqSymbol e378;
            public ZSTD_seqSymbol e379;
            public ZSTD_seqSymbol e380;
            public ZSTD_seqSymbol e381;
            public ZSTD_seqSymbol e382;
            public ZSTD_seqSymbol e383;
            public ZSTD_seqSymbol e384;
            public ZSTD_seqSymbol e385;
            public ZSTD_seqSymbol e386;
            public ZSTD_seqSymbol e387;
            public ZSTD_seqSymbol e388;
            public ZSTD_seqSymbol e389;
            public ZSTD_seqSymbol e390;
            public ZSTD_seqSymbol e391;
            public ZSTD_seqSymbol e392;
            public ZSTD_seqSymbol e393;
            public ZSTD_seqSymbol e394;
            public ZSTD_seqSymbol e395;
            public ZSTD_seqSymbol e396;
            public ZSTD_seqSymbol e397;
            public ZSTD_seqSymbol e398;
            public ZSTD_seqSymbol e399;
            public ZSTD_seqSymbol e400;
            public ZSTD_seqSymbol e401;
            public ZSTD_seqSymbol e402;
            public ZSTD_seqSymbol e403;
            public ZSTD_seqSymbol e404;
            public ZSTD_seqSymbol e405;
            public ZSTD_seqSymbol e406;
            public ZSTD_seqSymbol e407;
            public ZSTD_seqSymbol e408;
            public ZSTD_seqSymbol e409;
            public ZSTD_seqSymbol e410;
            public ZSTD_seqSymbol e411;
            public ZSTD_seqSymbol e412;
            public ZSTD_seqSymbol e413;
            public ZSTD_seqSymbol e414;
            public ZSTD_seqSymbol e415;
            public ZSTD_seqSymbol e416;
            public ZSTD_seqSymbol e417;
            public ZSTD_seqSymbol e418;
            public ZSTD_seqSymbol e419;
            public ZSTD_seqSymbol e420;
            public ZSTD_seqSymbol e421;
            public ZSTD_seqSymbol e422;
            public ZSTD_seqSymbol e423;
            public ZSTD_seqSymbol e424;
            public ZSTD_seqSymbol e425;
            public ZSTD_seqSymbol e426;
            public ZSTD_seqSymbol e427;
            public ZSTD_seqSymbol e428;
            public ZSTD_seqSymbol e429;
            public ZSTD_seqSymbol e430;
            public ZSTD_seqSymbol e431;
            public ZSTD_seqSymbol e432;
            public ZSTD_seqSymbol e433;
            public ZSTD_seqSymbol e434;
            public ZSTD_seqSymbol e435;
            public ZSTD_seqSymbol e436;
            public ZSTD_seqSymbol e437;
            public ZSTD_seqSymbol e438;
            public ZSTD_seqSymbol e439;
            public ZSTD_seqSymbol e440;
            public ZSTD_seqSymbol e441;
            public ZSTD_seqSymbol e442;
            public ZSTD_seqSymbol e443;
            public ZSTD_seqSymbol e444;
            public ZSTD_seqSymbol e445;
            public ZSTD_seqSymbol e446;
            public ZSTD_seqSymbol e447;
            public ZSTD_seqSymbol e448;
            public ZSTD_seqSymbol e449;
            public ZSTD_seqSymbol e450;
            public ZSTD_seqSymbol e451;
            public ZSTD_seqSymbol e452;
            public ZSTD_seqSymbol e453;
            public ZSTD_seqSymbol e454;
            public ZSTD_seqSymbol e455;
            public ZSTD_seqSymbol e456;
            public ZSTD_seqSymbol e457;
            public ZSTD_seqSymbol e458;
            public ZSTD_seqSymbol e459;
            public ZSTD_seqSymbol e460;
            public ZSTD_seqSymbol e461;
            public ZSTD_seqSymbol e462;
            public ZSTD_seqSymbol e463;
            public ZSTD_seqSymbol e464;
            public ZSTD_seqSymbol e465;
            public ZSTD_seqSymbol e466;
            public ZSTD_seqSymbol e467;
            public ZSTD_seqSymbol e468;
            public ZSTD_seqSymbol e469;
            public ZSTD_seqSymbol e470;
            public ZSTD_seqSymbol e471;
            public ZSTD_seqSymbol e472;
            public ZSTD_seqSymbol e473;
            public ZSTD_seqSymbol e474;
            public ZSTD_seqSymbol e475;
            public ZSTD_seqSymbol e476;
            public ZSTD_seqSymbol e477;
            public ZSTD_seqSymbol e478;
            public ZSTD_seqSymbol e479;
            public ZSTD_seqSymbol e480;
            public ZSTD_seqSymbol e481;
            public ZSTD_seqSymbol e482;
            public ZSTD_seqSymbol e483;
            public ZSTD_seqSymbol e484;
            public ZSTD_seqSymbol e485;
            public ZSTD_seqSymbol e486;
            public ZSTD_seqSymbol e487;
            public ZSTD_seqSymbol e488;
            public ZSTD_seqSymbol e489;
            public ZSTD_seqSymbol e490;
            public ZSTD_seqSymbol e491;
            public ZSTD_seqSymbol e492;
            public ZSTD_seqSymbol e493;
            public ZSTD_seqSymbol e494;
            public ZSTD_seqSymbol e495;
            public ZSTD_seqSymbol e496;
            public ZSTD_seqSymbol e497;
            public ZSTD_seqSymbol e498;
            public ZSTD_seqSymbol e499;
            public ZSTD_seqSymbol e500;
            public ZSTD_seqSymbol e501;
            public ZSTD_seqSymbol e502;
            public ZSTD_seqSymbol e503;
            public ZSTD_seqSymbol e504;
            public ZSTD_seqSymbol e505;
            public ZSTD_seqSymbol e506;
            public ZSTD_seqSymbol e507;
            public ZSTD_seqSymbol e508;
            public ZSTD_seqSymbol e509;
            public ZSTD_seqSymbol e510;
            public ZSTD_seqSymbol e511;
            public ZSTD_seqSymbol e512;

            public ref ZSTD_seqSymbol this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public Span<ZSTD_seqSymbol> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 513);

            public ref ZSTD_seqSymbol this[uint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get => ref AsSpan()[(int) index];
            }

            public ref ZSTD_seqSymbol this[nuint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [InlineMethod.Inline]
                get => ref AsSpan()[(int) index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public static implicit operator ZSTD_seqSymbol*(in _MLTable_e__FixedBuffer t)
            {
                fixed (ZSTD_seqSymbol *pThis = &t.e0)
                {
                    return pThis;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [InlineMethod.Inline]
            public static ZSTD_seqSymbol* operator +(in _MLTable_e__FixedBuffer t, uint index)
            {
                fixed (ZSTD_seqSymbol *pThis = &t.e0)
                {
                    return pThis + index;
                }
            }
        }
    }
}
