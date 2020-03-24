#version 330 core
layout (location = 0) in vec4 vertex; // <vec2 position, vec2 texCoords>

out vec2 TexCoords;

uniform bool  shake;
uniform float time;
uniform float strength;

void main()
{
    gl_Position = vec4(vertex.xy, 0.0f, 1.0f); 
    
    TexCoords = vertex.zw;
    if (shake)
    {
        gl_Position.x += cos(time * 10) * strength;        
        gl_Position.y += cos(time * 15) * strength;        
    }
}  