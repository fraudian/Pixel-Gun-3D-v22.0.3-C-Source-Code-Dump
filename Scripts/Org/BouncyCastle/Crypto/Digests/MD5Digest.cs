using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class MD5Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 16;
        private uint H1;
        private uint H2;
        private uint H3;
        private uint H4;
        private uint[] X;
        private int xOff;
        private static readonly int S11;
        private static readonly int S12;
        private static readonly int S13;
        private static readonly int S14;
        private static readonly int S21;
        private static readonly int S22;
        private static readonly int S23;
        private static readonly int S24;
        private static readonly int S31;
        private static readonly int S32;
        private static readonly int S33;
        private static readonly int S34;
        private static readonly int S41;
        private static readonly int S42;
        private static readonly int S43;
        private static readonly int S44;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public MD5Digest()
        {
            this.X = new uint[16];
            goto typeof(Org.BouncyCastle.Crypto.Digests.MD5Digest).__il2cppRuntimeField_1F8;
        }
        public MD5Digest(Org.BouncyCastle.Crypto.Digests.MD5Digest t)
        {
            this.X = new uint[16];
            Org.BouncyCastle.Crypto.Digests.MD5Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.MD5Digest t)
        {
            t.CopyIn(t:  t);
            if(t == null)
            {
                goto label_0;
            }
            
            this.H1 = t.H1;
            this.H2 = t.H2;
            this.H3 = t.H3;
            this.H4 = t.H4;
            if(t.X != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            System.Array.Copy(sourceArray:  t.X, sourceIndex:  0, destinationArray:  this.X, destinationIndex:  0, length:  t.X.Length);
            this.xOff = t.xOff;
            return;
            label_0:
            this.H1 = 135970152;
            this.H2 = 0;
            this.H3 = 0;
            this.H4 = 3670080;
            if(4194311 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public override string get_AlgorithmName()
        {
            return "MD5";
        }
        public override int GetDigestSize()
        {
            return 16;
        }
        internal override void ProcessWord(byte[] input, int inOff)
        {
            var val_8;
            System.UInt32[] val_9;
            val_8 = this;
            val_9 = this.X;
            val_9[(this.xOff) << 2] = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  input, off:  inOff);
            int val_8 = this.xOff;
            val_8 = val_8 + 1;
            this.xOff = val_8;
            if(val_8 != 16)
            {
                    return;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Digests.MD5Digest).__il2cppRuntimeField_228;
        }
        internal override void ProcessLength(long bitLength)
        {
            int val_2 = this.xOff;
            long val_2 = bitLength;
            if(val_2 < 15)
            {
                goto label_4;
            }
            
            if(val_2 == 15)
            {
                    this.X[7] = 0;
            }
            
            val_2 = this.xOff;
            goto label_4;
            label_7:
            var val_1 = X22 + (((long)(int)(this.xOff)) << 2);
            val_2 = val_2 + 1;
            mem2[0] = 0;
            label_4:
            if(val_2 < 14)
            {
                goto label_7;
            }
            
            this.X[7] = val_2;
            val_2 = val_2 >> 32;
            this.X[7] = val_2;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            this.Finish();
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.H1, bs:  output, off:  outOff);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.H2, bs:  output, off:  outOff + 4);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.H3, bs:  output, off:  outOff + 8);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.H4, bs:  output, off:  outOff + 12);
            return 16;
        }
        public override void Reset()
        {
            var val_1;
            this.Reset();
            val_1 = 0;
            this.xOff = 0;
            this.H1 = ;
            this.H2 = ;
            this.H3 = 1167088121787636990;
            this.H4 = 271733878;
            goto label_0;
            label_4:
            val_1 = 1;
            this.X[0] = 0;
            label_0:
            if(val_1 != this.X.Length)
            {
                goto label_4;
            }
        
        }
        private static uint RotateLeft(uint x, int n)
        {
            var val_1 = -n;
            val_1 = val_1 & 31;
            x = x >> val_1;
            return (uint)x;
        }
        private static uint F(uint u, uint v, uint w)
        {
            u = (w & (~u)) | (v & u);
            return (uint)u;
        }
        private static uint G(uint u, uint v, uint w)
        {
            u = (w & u) | (v & (~w));
            return (uint)u;
        }
        private static uint H(uint u, uint v, uint w)
        {
            u = v ^ u ^ w;
            return (uint)u;
        }
        private static uint K(uint u, uint v, uint w)
        {
            u = (u | (~w)) ^ v;
            return (uint)u;
        }
        internal override void ProcessBlock()
        {
            uint val_337 = this.H1;
            uint val_346 = this.H2;
            uint val_343 = this.H3;
            uint val_340 = this.H4;
            uint val_1 = val_343 & val_346;
            uint val_2 = val_340 & (~val_346);
            val_1 = val_2 | val_1;
            uint val_335 = this.X[0];
            uint val_3 = val_337 + val_1;
            val_335 = val_3 + val_335;
            val_335 = val_335 + 3614090360;
            var val_336 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S11;
            val_336 = val_336 & 31;
            val_336 = val_335 >> val_336;
            val_337 = val_336 + val_346;
            val_1 = val_337 & val_346;
            val_2 = val_343 & (~val_337);
            val_1 = val_2 | val_1;
            uint val_338 = this.X[0];
            val_3 = val_340 + val_1;
            val_338 = val_3 + val_338;
            val_338 = val_338 + 3905402710;
            var val_339 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S12;
            val_339 = val_339 & 31;
            val_339 = val_338 >> val_339;
            val_340 = val_339 + val_337;
            val_1 = val_340 & val_337;
            val_2 = val_346 & (~val_340);
            val_1 = val_2 | val_1;
            uint val_341 = this.X[1];
            val_3 = val_343 + val_1;
            val_341 = val_3 + val_341;
            val_341 = val_341 + 606105819;
            var val_342 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S13;
            val_342 = val_342 & 31;
            val_342 = val_341 >> val_342;
            val_343 = val_342 + val_340;
            val_1 = val_343 & val_340;
            val_2 = val_337 & (~val_343);
            val_1 = val_2 | val_1;
            uint val_344 = this.X[1];
            val_3 = val_346 + val_1;
            val_344 = val_3 + val_344;
            val_344 = val_344 + 3250441966;
            var val_345 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S14;
            val_345 = val_345 & 31;
            val_345 = val_344 >> val_345;
            val_346 = val_345 + val_343;
            val_1 = val_346 & val_343;
            val_2 = val_340 & (~val_346);
            val_1 = val_2 | val_1;
            uint val_347 = this.X[2];
            val_3 = val_337 + val_1;
            val_347 = val_3 + val_347;
            val_347 = val_347 + 4118548399;
            var val_348 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S11;
            val_348 = val_348 & 31;
            val_348 = val_347 >> val_348;
            val_337 = val_348 + val_346;
            val_1 = val_337 & val_346;
            val_2 = val_343 & (~val_337);
            val_1 = val_2 | val_1;
            uint val_349 = this.X[2];
            val_3 = val_340 + val_1;
            val_349 = val_3 + val_349;
            val_349 = val_349 + 1200080426;
            var val_350 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S12;
            val_350 = val_350 & 31;
            val_350 = val_349 >> val_350;
            val_340 = val_350 + val_337;
            val_1 = val_340 & val_337;
            val_2 = val_346 & (~val_340);
            val_1 = val_2 | val_1;
            uint val_351 = this.X[3];
            val_3 = val_343 + val_1;
            var val_352 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S13;
            val_352 = val_352 & 31;
            val_352 = val_3 >> val_352;
            val_343 = val_352;
            val_1 = val_343;
            uint val_7 = val_337;
            uint val_353 = this.X[3];
            val_353 = (val_346 + val_7) + val_353;
            val_353 = val_353 + 4249261313;
            var val_354 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S14;
            val_354 = val_354 & 31;
            val_354 = val_353 >> val_354;
            val_346 = val_354;
            val_7 = val_346;
            uint val_10 = val_340;
            uint val_355 = this.X[4];
            var val_356 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S11;
            val_356 = val_356 & 31;
            val_356 = (val_337 + val_10) >> val_356;
            val_337 = val_356;
            val_10 = val_337;
            uint val_15 = val_343;
            uint val_357 = this.X[4];
            val_357 = val_340 + val_357;
            var val_358 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S12;
            val_358 = val_358 & 31;
            val_358 = val_357 >> val_358;
            val_340 = val_358;
            uint val_18 = val_340;
            uint val_20 = val_346;
            uint val_359 = this.X[5];
            System.UInt32[] val_363 = this.X;
            var val_360 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S13;
            val_360 = val_360 & 31;
            val_360 = val_343 >> val_360;
            uint val_24 = val_360;
            uint val_25 = val_24;
            uint val_27 = val_337;
            uint val_361 = val_363[5];
            val_361 = val_346 + val_361;
            val_361 = val_361 + 2304563134;
            var val_362 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S14;
            val_362 = val_362 & 31;
            val_362 = val_361 >> val_362;
            val_363 = val_362;
            uint val_29 = val_363;
            uint val_31 = val_340;
            uint val_364 = this.X[6];
            var val_365 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S11;
            val_365 = val_365 & 31;
            val_365 = val_337 >> val_365;
            uint val_35 = val_365;
            uint val_36 = val_35;
            uint val_38 = val_24;
            uint val_366 = this.X[6];
            var val_367 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S12;
            val_367 = val_367 & 31;
            val_367 = val_340 >> val_367;
            uint val_42 = val_367;
            uint val_43 = val_42;
            uint val_45 = val_363;
            uint val_368 = this.X[7];
            var val_369 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S13;
            val_369 = val_369 & 31;
            val_369 = val_24 >> val_369;
            uint val_49 = val_369;
            uint val_50 = val_49;
            uint val_52 = val_35;
            uint val_370 = this.X[7];
            uint val_56 = val_49;
            var val_371 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S14;
            val_371 = val_371 & 31;
            val_371 = val_363 >> val_371;
            val_363 = val_371;
            uint val_58 = val_363;
            uint val_372 = this.X[0];
            uint val_62 = val_363;
            var val_373 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S21;
            val_373 = val_373 & 31;
            val_373 = val_35 >> val_373;
            uint val_63 = val_373;
            uint val_65 = val_63;
            uint val_374 = this.X[3];
            uint val_69 = val_63;
            var val_375 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S22;
            val_375 = val_375 & 31;
            val_375 = val_42 >> val_375;
            uint val_70 = val_375;
            val_42 = val_70;
            uint val_71 = val_42;
            uint val_376 = this.X[5];
            uint val_75 = val_70;
            var val_377 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S23;
            val_377 = val_377 & 31;
            val_377 = val_49 >> val_377;
            uint val_76 = val_377;
            uint val_78 = val_76;
            uint val_378 = this.X[0];
            uint val_82 = val_76;
            var val_379 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S24;
            val_379 = val_379 & 31;
            val_379 = val_363 >> val_379;
            uint val_83 = val_379;
            uint val_85 = val_83;
            uint val_380 = this.X[2];
            uint val_89 = val_83;
            var val_381 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S21;
            val_381 = val_381 & 31;
            val_381 = val_63 >> val_381;
            uint val_90 = val_381;
            uint val_92 = val_90;
            uint val_382 = this.X[5];
            uint val_96 = val_90;
            var val_383 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S22;
            val_383 = val_383 & 31;
            val_383 = val_70 >> val_383;
            uint val_97 = val_383;
            uint val_99 = val_97;
            uint val_384 = this.X[7];
            uint val_103 = val_97;
            var val_385 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S23;
            val_385 = val_385 & 31;
            val_385 = val_76 >> val_385;
            uint val_104 = val_385;
            uint val_106 = val_104;
            uint val_386 = this.X[2];
            uint val_110 = val_104;
            var val_387 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S24;
            val_387 = val_387 & 31;
            val_387 = val_83 >> val_387;
            val_83 = val_387;
            uint val_112 = val_83;
            uint val_388 = this.X[4];
            uint val_116 = val_83;
            var val_389 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S21;
            val_389 = val_389 & 31;
            val_389 = val_90 >> val_389;
            val_90 = val_389;
            uint val_118 = val_90;
            uint val_390 = this.X[7];
            uint val_122 = val_90;
            var val_391 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S22;
            val_391 = val_391 & 31;
            val_391 = val_97 >> val_391;
            val_97 = val_391;
            uint val_124 = val_97;
            uint val_392 = this.X[1];
            uint val_128 = val_97;
            var val_393 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S23;
            val_393 = val_393 & 31;
            val_393 = val_104 >> val_393;
            val_104 = val_393;
            uint val_130 = val_104;
            uint val_394 = this.X[4];
            uint val_134 = val_104;
            var val_395 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S24;
            val_395 = val_395 & 31;
            val_395 = val_83 >> val_395;
            val_83 = val_395;
            uint val_136 = val_83;
            uint val_396 = this.X[6];
            uint val_140 = val_83;
            var val_397 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S21;
            val_397 = val_397 & 31;
            val_397 = val_90 >> val_397;
            val_90 = val_397;
            uint val_142 = val_90;
            uint val_398 = this.X[1];
            uint val_146 = val_90;
            var val_399 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S22;
            val_399 = val_399 & 31;
            val_399 = val_97 >> val_399;
            val_97 = val_399;
            uint val_148 = val_97;
            uint val_400 = this.X[3];
            uint val_152 = val_97;
            var val_401 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S23;
            val_401 = val_401 & 31;
            val_401 = val_104 >> val_401;
            val_104 = val_401;
            uint val_154 = val_104;
            uint val_402 = this.X[6];
            var val_403 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S24;
            val_403 = val_403 & 31;
            val_403 = val_83 >> val_403;
            val_83 = val_403;
            uint val_159 = val_104;
            uint val_404 = this.X[2];
            var val_405 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S31;
            val_405 = val_405 & 31;
            val_405 = val_90 >> val_405;
            val_90 = val_405;
            uint val_164 = val_83;
            uint val_406 = this.X[4];
            var val_407 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S32;
            val_407 = val_407 & 31;
            val_407 = val_97 >> val_407;
            val_97 = val_407;
            uint val_169 = val_90;
            uint val_408 = this.X[5];
            var val_409 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S33;
            val_409 = val_409 & 31;
            val_409 = val_104 >> val_409;
            val_104 = val_409;
            uint val_174 = val_97;
            uint val_410 = this.X[7];
            var val_411 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S34;
            val_411 = val_411 & 31;
            val_411 = val_83 >> val_411;
            val_83 = val_411;
            uint val_179 = val_104;
            uint val_412 = this.X[0];
            var val_413 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S31;
            val_413 = val_413 & 31;
            val_413 = val_90 >> val_413;
            val_90 = val_413;
            uint val_184 = val_83;
            uint val_414 = this.X[2];
            var val_415 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S32;
            val_415 = val_415 & 31;
            val_415 = val_97 >> val_415;
            val_97 = val_415;
            uint val_189 = val_90;
            uint val_416 = this.X[3];
            var val_417 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S33;
            val_417 = val_417 & 31;
            val_417 = val_104 >> val_417;
            val_104 = val_417;
            uint val_194 = val_97;
            uint val_418 = this.X[5];
            var val_419 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S34;
            val_419 = val_419 & 31;
            val_419 = val_83 >> val_419;
            uint val_199 = val_419;
            uint val_200 = val_104;
            uint val_420 = this.X[6];
            var val_421 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S31;
            val_421 = val_421 & 31;
            val_421 = val_90 >> val_421;
            uint val_205 = val_421;
            uint val_206 = val_199;
            uint val_422 = this.X[0];
            var val_423 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S32;
            val_423 = val_423 & 31;
            val_423 = val_97 >> val_423;
            uint val_211 = val_423;
            uint val_212 = val_205;
            uint val_424 = this.X[1];
            var val_425 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S33;
            val_425 = val_425 & 31;
            val_425 = val_104 >> val_425;
            uint val_217 = val_425;
            uint val_218 = val_211;
            uint val_426 = this.X[3];
            var val_427 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S34;
            val_427 = val_427 & 31;
            val_427 = val_199 >> val_427;
            uint val_223 = val_427;
            uint val_224 = val_217;
            uint val_428 = this.X[4];
            var val_429 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S31;
            val_429 = val_429 & 31;
            val_429 = val_205 >> val_429;
            uint val_229 = val_429;
            uint val_230 = val_223;
            uint val_430 = this.X[6];
            var val_431 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S32;
            val_431 = val_431 & 31;
            val_431 = val_211 >> val_431;
            uint val_235 = val_431;
            uint val_236 = val_229;
            uint val_432 = this.X[7];
            var val_433 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S33;
            val_433 = val_433 & 31;
            val_433 = val_217 >> val_433;
            uint val_242 = val_235;
            uint val_434 = this.X[1];
            var val_435 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S34;
            val_435 = val_435 & 31;
            val_435 = val_223 >> val_435;
            uint val_246 = val_435;
            uint val_248 = val_246;
            uint val_436 = this.X[0];
            var val_437 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S41;
            val_437 = val_437 & 31;
            val_437 = val_229 >> val_437;
            uint val_252 = val_437;
            uint val_254 = val_252;
            uint val_438 = this.X[3];
            var val_439 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S42;
            val_439 = val_439 & 31;
            val_439 = val_235 >> val_439;
            uint val_258 = val_439;
            uint val_260 = val_258;
            uint val_440 = this.X[7];
            var val_441 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S43;
            val_441 = val_441 & 31;
            val_441 = val_433 >> val_441;
            uint val_264 = val_441;
            uint val_266 = val_264;
            uint val_442 = this.X[2];
            var val_443 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S44;
            val_443 = val_443 & 31;
            val_443 = val_246 >> val_443;
            val_246 = val_443;
            uint val_271 = val_246;
            uint val_444 = this.X[6];
            var val_445 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S41;
            val_445 = val_445 & 31;
            val_445 = val_252 >> val_445;
            val_252 = val_445;
            uint val_276 = val_252;
            uint val_446 = this.X[1];
            var val_447 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S42;
            val_447 = val_447 & 31;
            val_447 = val_258 >> val_447;
            val_258 = val_447;
            uint val_281 = val_258;
            uint val_448 = this.X[5];
            var val_449 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S43;
            val_449 = val_449 & 31;
            val_449 = val_264 >> val_449;
            val_264 = val_449;
            uint val_286 = val_264;
            uint val_450 = this.X[0];
            var val_451 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S44;
            val_451 = val_451 & 31;
            val_451 = val_246 >> val_451;
            val_246 = val_451;
            uint val_291 = val_246;
            uint val_452 = this.X[4];
            var val_453 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S41;
            val_453 = val_453 & 31;
            val_453 = val_252 >> val_453;
            val_252 = val_453;
            uint val_296 = val_252;
            uint val_454 = this.X[7];
            var val_455 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S42;
            val_455 = val_455 & 31;
            val_455 = val_258 >> val_455;
            val_258 = val_455;
            uint val_301 = val_258;
            uint val_456 = this.X[3];
            var val_457 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S43;
            val_457 = val_457 & 31;
            val_457 = val_264 >> val_457;
            val_264 = val_457;
            uint val_306 = val_264;
            uint val_458 = this.X[6];
            var val_459 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S44;
            val_459 = val_459 & 31;
            val_459 = val_246 >> val_459;
            val_246 = val_459;
            uint val_311 = val_246;
            uint val_460 = this.X[2];
            var val_461 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S41;
            val_461 = val_461 & 31;
            val_461 = val_252 >> val_461;
            val_252 = val_461;
            uint val_316 = val_252;
            uint val_462 = this.X[5];
            var val_463 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S42;
            val_463 = val_463 & 31;
            val_463 = val_258 >> val_463;
            val_258 = val_463;
            uint val_321 = val_258;
            uint val_464 = this.X[1];
            var val_465 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S43;
            val_465 = val_465 & 31;
            val_465 = val_264 >> val_465;
            val_264 = val_465;
            uint val_326 = val_264;
            uint val_466 = this.X[4];
            uint val_329 = val_246;
            var val_467 = -Org.BouncyCastle.Crypto.Digests.MD5Digest.S44;
            val_467 = val_467 & 31;
            val_329 = val_329 >> val_467;
            this.H3 = this.H3;
            this.H4 = this.H4;
            this.H1 = this.H1;
            this.H2 = val_329;
            this.xOff = 0;
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.MD5Digest(t:  this);
        }
        public override void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            Org.BouncyCastle.Utilities.IMemoable val_3 = other;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.CopyIn(t:  val_3);
        }
        private static MD5Digest()
        {
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S11 = 7;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S12 = 12;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S13 = 17;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S14 = 22;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S21 = 5;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S22 = 9;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S23 = 14;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S24 = 20;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S31 = 4;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S32 = 11;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S33 = 16;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S34 = 23;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S41 = 6;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S42 = 10;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S43 = 15;
            Org.BouncyCastle.Crypto.Digests.MD5Digest.S44 = 21;
        }
    
    }

}
