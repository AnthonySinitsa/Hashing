public struct SmallXXHash {

	const uint primeA = 0b10011110001101110111100110110001;
	const uint primeB = 0b10000101111010111100101001110111;
	const uint primeC = 0b11000010101100101010111000111101;
	const uint primeD = 0b00100111110101001110101100101111;
	const uint primeE = 0b00010110010101100110011110110001;
}

uint accumulator;

public SmallXXHash(int seed){
    accumulator = (uint)seed + primeE;
}

public static implicit operator uint (SmallXXHash hash) => hash.accumulator;