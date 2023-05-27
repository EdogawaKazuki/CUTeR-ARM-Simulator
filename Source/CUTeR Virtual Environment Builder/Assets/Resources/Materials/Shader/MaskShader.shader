
Shader"Custom/MaskShader"{

	SubShader{

		// Geometry=2000
		// 先于实体层渲染，保证能遮挡实体层之后的渲染
		Tags{"Queue" = "Geometry-10"}

		// 关闭灯效影响
		Lighting off

		// 相当于小于或者等于本身深度值时，该物体渲染
		ZTest LEqual  // 与默认的属性一致，可以不写

		// 打开深度写入
		ZWrite On	// 与默认的属性一致，可以不写

		// 通道遮罩，为0时不写入任何颜色通道，除了深度缓存
		ColorMask 0

		Pass{}

	}

}