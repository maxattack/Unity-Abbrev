using UnityEngine;

public class MonoBehaviourWithAbbrev : MonoBehaviour {
	
	public static Vector2 Vec(float x, float y) { return new Vector2(x, y); }
	public static Vector2 Cmul(Vector2 u, Vector2 v) { return new Vector2(u.x*v.x-u.y*v.y, u.x*v.y + u.y*v.x); }
	public static Vector2 VDeg(float degrees) { return new Vector2(Mathf.Cos(degrees * Mathf.Deg2Rad), Mathf.Sin(degrees * Mathf.Deg2Rad)); }
	public static Vector2 VRad(float radians) { return new Vector2(Mathf.Cos(radians), Mathf.Sin(radians)); }

	public static Vector3 Vec(float x, float y, float z) { return new Vector3(x, y, z); }
	public static Vector3 Vec(float x, Vector2 yz) { return new Vector3(x, yz.x, yz.y); }
	public static Vector3 Vec(Vector2 v, float z) { return new Vector3(v.x, v.y, z); }

	public static Vector4 Vec(float x, float y, float z, float w) { return new Vector4(x, y, z, w); }
	public static Vector4 Vec(Vector3 v, float w) { return new Vector4(v.x, v.y, v.z, w); }

	public static Quaternion QDeg(float degrees) { return Quaternion.AngleAxis(degrees, Vector3.forward); }
	public static Quaternion QRad(float radians) { return Quaternion.AngleAxis(radians * Mathf.Rad2Deg, Vector3.forward); }
	public static Quaternion QDir(Vector2 dir) { return Quaternion.AngleAxis(dir.Deg(), Vector3.forward); }

	public static Color32 RGB(uint hex) {
		return new Color32(
			(byte)((0xff0000 & hex) >> 16),
			(byte)((0x00ff00 & hex) >>  8),
			(byte)((0x0000ff & hex)      ),
			(byte)255
		);		
	}
	
	public static Color32 RGBA(uint hex) {
		return new Color32(
			(byte)((0xff000000 & hex) >> 24),
			(byte)((0x00ff0000 & hex) >> 16),
			(byte)((0x0000ff00 & hex) >>  8),
			(byte)((0x000000ff & hex)      )
		);
	}
	
	public static Color RGB(float r, float g, float b) { return new Color(r, g, b); }
	public static Color RGBA(float r, float g, float b, float a) { return new Color(r, g, b, a); }
	public static Color RGBA(Color c, float a) { return new Color(c.r, c.g, c.b, a); }
	
}


