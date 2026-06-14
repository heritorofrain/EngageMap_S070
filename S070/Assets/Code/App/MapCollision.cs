using UnityEngine;

using Bridge;

namespace App
{
	public class MapCollision : MonoBehaviour
	{
		public MapObject m_MapObject; // 0x18
		public Renderer[] m_Renderers; // 0x20
		public float m_Alpha; // 0x28
		[HideInInspector] // RVA: 0x18AD80 Offset: 0x18AE81 VA: 0x18AD80
		public bool m_DisableCloseTransparent; // 0x2C
	}
}