#version 330 core
in vec2 TexCoords;
out vec4 color;
uniform sampler2D image;
uniform vec4 spriteColor;
uniform vec2 texSize;
uniform vec2 flipTex;
uniform vec2 texPos;
void main()
{
color = spriteColor * texture(image, (TexCoords * flipTex + texPos) * texSize);
}