using UnityEngine;

public static class AbbrevExtensions {

	public static Vector2 yx(this Vector2 v) { return new Vector2(v.y, v.x); }
	public static Vector2 xy(this Vector3 v) { return new Vector3(v.x, v.y); }
	public static Vector2 yx(this Vector3 v) { return new Vector3(v.y, v.x); }
	public static Vector2 xz(this Vector3 v) { return new Vector3(v.x, v.z); }
	public static Vector2 yz(this Vector3 v) { return new Vector3(v.y, v.z); }
	public static Vector2 zx(this Vector3 v) { return new Vector3(v.z, v.x); }
	public static Vector2 zy(this Vector3 v) { return new Vector3(v.z, v.y); }
	public static Vector3 x0z(this Vector3 v) { return new Vector3(v.x, 0f, v.z); }

	public static Vector2 Conj(this Vector2 v) { return new Vector2(v.x, -v.y); }
	public static float Rad(this Vector2 v) { return Mathf.Atan2(v.y, v.x); }
	public static float Deg(this Vector2 v) { return Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg; }

	public static Vector2 Anticlockwise(this Vector2 v) { return new Vector2(-v.y, v.x); }
	public static Vector2 Clockwise(this Vector2 v) { return new Vector2(v.y, -v.x); }
	public static Vector3 AnticlockwiseXZ(this Vector3 v) { return new Vector3(-v.z, v.y, v.x); }
	public static Vector3 ClockwiseXZ(this Vector3 v) { return new Vector3(v.z, v.y, -v.x); }
	
	public static Vector3 Above(this Vector3 v, float dh) { return new Vector3(v.x, v.y+dh, v.z); }
	public static Vector3 Below(this Vector3 v, float dh) { return new Vector3(v.x, v.y-dh, v.z); }
	public static Vector3 Ahead(this Vector3 v, float dz) { return new Vector3(v.x, v.y, v.z+dz); }
	public static Vector3 Behind(this Vector3 v, float dz) { return new Vector3(v.x, v.y, v.z-dz); }
	public static Vector3 Left(this Vector3 v, float dx) { return new Vector3(v.x-dx, v.y, v.z); }
	public static Vector3 Right(this Vector3 v, float dx) { return new Vector3(v.x+dx, v.y, v.z); }

	public static Vector3 Fwd(this Quaternion q)   { return q * (new Vector3(0f, 0f, 1f)); }
	public static Vector3 Bwd(this Quaternion q)   { return q * (new Vector3(0f, 0f, -1f)); }
	public static Vector3 Right(this Quaternion q) { return q * (new Vector3(1f, 0f, 0f)); }
	public static Vector3 Left(this Quaternion q)  { return q * (new Vector3(-1f, 0f, 0f)); }
	public static Vector3 Up(this Quaternion q)    { return q * (new Vector3(0f, 1f, 0f)); }
	public static Vector3 Down(this Quaternion q)  { return q * (new Vector3(0f, -1f, 0f)); }

}




