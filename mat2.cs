namespace Quickmaths {

public partial struct mat2 {

    public static readonly mat2 IDENTITY = new mat2(
        1, 0,
        0, 1 );

    public float m11, m12,
                 m21, m22;

	//////////////////////////////////////////////////////////////////////////
	// Constructors	 
	////////////////////////////////////////////////////////////////////////// 

    public mat2(float m11, float m12,
                float m21, float m22 ) {

        // Row 1
        this.m11 = m11;
        this.m12 = m12;
        // Row 2
        this.m21 = m21;
        this.m22 = m22;
    }

	//////////////////////////////////////////////////////////////////////////
	// Methods	 
	//////////////////////////////////////////////////////////////////////////

    public mat2 transpose() {
        return new mat2(
            m11, m21,
            m12, m22 );
    }
    
    public static mat2 fromScale(vec2 scale) {
        return new mat2(
            scale.x, 0,
            0, scale.y );
    }

    public static mat2 fromRotation(float angle) {
        float c = Math.cos(angle);
        float s = Math.sin(angle);

        return new mat2(
            c, s,
           -s, c );
    }

    public static mat2 fromTransform(float angle, vec2 scale) {
        return fromScale(scale) * fromRotation(angle);
    }

    // https://www.mathsisfun.com/algebra/matrix-inverse-row-operations-gauss-jordan.html
    public mat2 inverse() {

        float determinant = this.determinant();

        // Matrix is singular
        if (determinant == 0f)
            return IDENTITY;

        return new mat2(
            this.m22/determinant,-this.m12/determinant,
           -this.m21/determinant, this.m11/determinant );
    }

    public float determinant() {
        return m11*m22 - m12*m21;
    }

	//////////////////////////////////////////////////////////////////////////
	// Overrides	 
	//////////////////////////////////////////////////////////////////////////

	override public string ToString() {
        return "|" + m11 + "," + m12 + "|"
           + "\n|" + m21 + "," + m22 + "|";
	}

	override public bool Equals(object o) {
        if (!(o is mat2))
            return false;

		return this == (mat2) o;
	}
    
    override public int GetHashCode() {
        return this.ToString().GetHashCode();
	}

	//////////////////////////////////////////////////////////////////////////
	// Casting	 
	//////////////////////////////////////////////////////////////////////////

    public static explicit operator mat2(float[] m) {
        return new mat2(
            m[0], m[1],
            m[2], m[3] );
    }

    public static explicit operator float[](mat2 m) {
        return new float[] {
            m.m11, m.m12,
            m.m21, m.m22 };
    }

    public static explicit operator mat2(float[,] m) {
        return new mat2(
            m[0,0], m[0,1],
            m[1,0], m[1,1] );
    }

    public static explicit operator float[,](mat2 m) {
        return new float[,] {
            { m.m11, m.m12 },
            { m.m21, m.m22 } };
    }

	//////////////////////////////////////////////////////////////////////////
	// Operators	 
	//////////////////////////////////////////////////////////////////////////

    public static bool operator==(mat2 a, mat2 b) {
		return a.m11 == b.m11 && a.m12 == b.m12
            && a.m21 == b.m21 && a.m22 == b.m22;
	}

	public static bool operator!=(mat2 a, mat2 b) {
		return a.m11 != b.m11 || a.m12 != b.m12
            || a.m21 != b.m21 || a.m22 != b.m22;
	}

	public static mat2 operator*(mat2 a, mat2 b) {
        return new mat2(
            // Row 1
            a.m11*b.m11 + a.m12*b.m21,
            a.m11*b.m12 + a.m12*b.m22,
            // Row 2
            a.m21*b.m11 + a.m22*b.m21,
            a.m21*b.m12 + a.m22*b.m22 );
	}

	public static mat2 operator*(mat2 a, vec2 b) {
        return new mat2(
            a.m11*b.x, a.m12*b.x,
            a.m21*b.y, a.m22*b.y );
	}

    public static mat2 operator*(vec2 a, mat2 b) => b * a;

	public static mat2 operator*(mat2 a, float b) {
        return new mat2(
            a.m11*b, a.m12*b,
            a.m21*b, a.m22*b );
	}

    public static mat2 operator*(float a, mat2 b) => b * a;

}
}