
/*
* Start with this code (a very stripped down version of ballAndTorusShadowed.cpp)
*
* It will provide all with a general environment within which to program, including
* a bit of scale provided by the checkered floor.
*
* The wire cones are included only to show the origin and direction of axes (and scale).
* REMOVE the cones first, then...
*
* REPLACE this comment with your name and the program (step) you are working on!
*
*/

#include <iostream>

#ifdef __APPLE__
#  include <GL/glew.h>
#  include <GL/freeglut.h>
#  include <OpenGL/glext.h>
#else
#  include <GL/glew.h>
#  include <GL/freeglut.h>
#  include "getBMP.h"
//#  include <GL/glext.h>
#pragma comment(lib, "glew32.lib")
#endif


using namespace std;

static float angle = 0;
static unsigned int texture[3]; // Array of texture indices.
static int isFog = 1; // Is fog on?
static float fogColor[4] = { 0.5, 0.5, 0.5, 1.0 };
static int fogMode = GL_EXP2; // Fog mode.
static float fogDensity = 0.05; // Fog density.

// Rotates camera around the orgin
// Source of help: https://stackoverflow.com/questions/287655/opengl-rotating-a-camera-around-a-point
void animateCamera(int value)
{
	if (angle < 360) {
		glRotatef(angle, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		glutTimerFunc(10, animateCamera, 1);
		angle += 1;
	}
	else angle = 0;
}

void animateReverseCamera(int value)
{
	if (angle >= -360) {
		glRotatef(angle, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		glutTimerFunc(10, animateReverseCamera, 1);
		angle -= 1;
	}
	else angle = 0;
}

// Load external textures.
void loadTextures()
{
	imageFile *image[1];
	image[0] = getBMP("texture1.bmp");

	// Create texture object texture[]. 
	glBindTexture(GL_TEXTURE_2D, texture[0]);

	// Specify image data for currently active texture object.
	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, image[0]->width, image[0]->height, 0,
		GL_RGBA, GL_UNSIGNED_BYTE, image[0]->data);

	// Set texture parameters for wrapping.
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);

	// Set texture parameters for filtering.
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
}



// Draw checkered floor.
void drawCheckeredFloor(void)
{
	glShadeModel(GL_FLAT); // Flat shading to get the checkered pattern.
	int i = 0;

	glPushMatrix();
	for (float z = 50.0; z > -50.0; z -= 5.0)
	{
		glBegin(GL_TRIANGLE_STRIP);
		for (float x = -50.0; x < 50.0; x += 5.0)
		{
			if (i % 2) glColor3f(0.0, 0.0, 0.0);
			else glColor3f(1.0, 1.0, 1.0);
			glNormal3f(0.0, 1.0, 0.0);
			glVertex3f(x, 0.0, z - 5.0);
			glVertex3f(x, 0.0, z);
			i++;
		}
		glEnd();
		i++;
	}
	glPopMatrix();
}

// Initialization routine.
void setup(void)
{
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glEnable(GL_DEPTH_TEST); // Enable depth testing.

	glEnable(GL_BLEND); // Enable blending.
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA); // Add transparency to opaque/alpha value
	glEnable(GL_LINE_SMOOTH); // Enable line antialiasing.
	glEnable(GL_POINT_SMOOTH);  // Enable point antialiasing.

	// Fog controls.
	glFogfv(GL_FOG_COLOR, fogColor);
	glFogi(GL_FOG_MODE, fogMode);
	glFogf(GL_FOG_DENSITY, fogDensity);
	
	// Turn on OpenGL lighting.
	glEnable(GL_LIGHTING);

	// Light property vectors.
	float lightAmb[] = { 0.6, 0.6, 0.0, 1.0 }; // 1st & 2nd values changed to add yellow to light source
	float lightDifAndSpec[] = { 1.0, 1.0, 1.0, 1.0 };
	// Changed x, y, and Z values so light source (sun) appears from over right shoulder
	float lightPos[] = { 1.0, 1.0, 1.0, 0.0 }; // Overhead directional light source (e.g., sun).
	float globAmb[] = { 0.4, 0.4, 0.7, 1.0 }; //3rd value changed to add slight blue to global ambient

	// Light properties.
	glLightfv(GL_LIGHT0, GL_AMBIENT, lightAmb);
	glLightfv(GL_LIGHT0, GL_DIFFUSE, lightDifAndSpec);
	glLightfv(GL_LIGHT0, GL_SPECULAR, lightDifAndSpec);
	glLightfv(GL_LIGHT0, GL_POSITION, lightPos);
	glEnable(GL_LIGHT0); // Enable particular light source.
	glLightModelfv(GL_LIGHT_MODEL_AMBIENT, globAmb); // Global ambient light.

													 // Material property vectors.
	float matSpec[] = { 1.0, 1.0, 1.0, 1.0 };
	float matShine[] = { 50.0 };

	// Material properties.
	glMaterialfv(GL_FRONT, GL_SPECULAR, matSpec);
	glMaterialfv(GL_FRONT, GL_SHININESS, matShine);

	// Enable color material mode.
	glEnable(GL_COLOR_MATERIAL);
	glColorMaterial(GL_FRONT, GL_AMBIENT_AND_DIFFUSE);

	// Cull back faces.
	glEnable(GL_CULL_FACE);
	glCullFace(GL_BACK);

	// Create texture ids.
	glGenTextures(1, texture);

	// Load texture.
	loadTextures();

	// Specify how texture values combine with current surface color values.
	glTexEnvf(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_MODULATE);
}

// Drawing routine.
void drawScene(void)
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

	float xyz, xyz2; // Declare Constants
	xyz = 1.75; // Size of shapes
	xyz2 = 3.25;

	glEnable(GL_FOG); // Adds fog

	glLoadIdentity();
	gluLookAt(0.0, 11.0, 5.0, // eye location
		0.0, 0.0, 0.0, 	// look at point
		0.0, 1.0, 0.0);  // up vector

	glRotatef(angle, 0.0, 1.0, 0.0);

	drawCheckeredFloor(); // Draw the floor first.
						  // This code is just to orient you in the scene and should be removed
	glTranslatef(0, 0.01, 0); // slight vertical offset to make sure lines are visible

	glTranslatef(0, 0.0, -6.0); // Shifts objects 6 units away on Z-axis
	
	//Draw Rectangular Prism for platform
	glColor3f(.2, .2, .2); //Dark Grey
	glBegin(GL_QUADS);
		//Top
		glVertex3f(xyz, xyz, -xyz);
		glVertex3f(-xyz, xyz, -xyz);
		glVertex3f(-xyz, xyz, xyz);
		glVertex3f(xyz, xyz, xyz);
	
		//Bottom
		glVertex3f(xyz, 0, -xyz);
		glVertex3f(-xyz, 0, -xyz);
		glVertex3f(-xyz, 0, xyz);
		glVertex3f(xyz, 0, xyz);
	
		//Front
		glVertex3f(-xyz, 0, xyz);
		glVertex3f(xyz, 0, xyz);
		glVertex3f(xyz, xyz, xyz);
		glVertex3f(-xyz, xyz, xyz);

		//Back
		glVertex3f(-xyz, 0, -xyz);
		glVertex3f(xyz, 0, -xyz);
		glVertex3f(xyz, xyz, -xyz);
		glVertex3f(-xyz, xyz, -xyz);

		//Left
		glVertex3f(-xyz, 0, -xyz);
		glVertex3f(-xyz, xyz, -xyz);
		glVertex3f(-xyz, xyz, xyz);
		glVertex3f(-xyz, 0, xyz);

		//Right
		glVertex3f(xyz, xyz, -xyz);
		glVertex3f(xyz, 0, -xyz);
		glVertex3f(xyz, 0, xyz);
		glVertex3f(xyz, xyz, xyz);
	glEnd();

	//Source of help, also used on project 6: https://www.opengl.org/discussion_boards/showthread.php/164143-Put-texture-on-a-sphere
	GLUquadric *qobj = gluNewQuadric();
	gluQuadricTexture(qobj, GL_TRUE);

	glEnable(GL_TEXTURE_2D);
		glBindTexture(GL_TEXTURE_2D, texture[0]); // Applies texture to snowballs
		glTranslatef(0, 1.5*xyz, 0.0); // Shifts snowball on top of platform
		glColor3f(.8, .8, .8); //Light Grey

		//Source of help: https://stackoverflow.com/questions/26936685/scaling-3d-shapes-opengl-and-c
		glScaled(1, .25 ,1); // Scale sphere to flatten it, 
		//guess this could have been used on a cube to make the platform easier, oh well, at least I know for sure that the sizing for that as percise as it is in directions
		
		gluSphere(qobj, xyz, 40, 40);
		glTranslatef(0, 1.5*xyz, 0.0); // Shifts snowball on top of the other snowball
		
		gluSphere(qobj, xyz - 0.35, 40, 40);
		glTranslatef(0, 1.5*xyz, 0.0); // Shifts snowball on top of the other snowball
		
		gluSphere(qobj, xyz - 0.7, 40, 40);
		glScaled(1, 4, 1); // Returns scaling to normal in case of other objects
	glDisable(GL_TEXTURE_2D);

	glTranslatef(0, 0.0, 2); 

	glBegin(GL_QUADS);
		//Left
		glColor4f(0, 1, 0, 0.5); //Green
		glVertex3f(-xyz2, 0, -xyz2);
		glVertex3f(-xyz2, xyz2, -xyz2);
		glVertex3f(-xyz2, xyz2, xyz2);
		glVertex3f(-xyz2, 0, xyz2);

		//Right
		glColor4f(0, 1, 1, 0.5); //Cyan
		glVertex3f(xyz2, xyz2, -xyz2);
		glVertex3f(xyz2, 0, -xyz2);
		glVertex3f(xyz2, 0, xyz2);
		glVertex3f(xyz2, xyz2, xyz2);

		//Front
		glColor4f(1, 0, 0, 0.5); //Red
		glVertex3f(-xyz2, 0, xyz2);
		glVertex3f(xyz2, 0, xyz2);
		glVertex3f(xyz2, xyz2, xyz2);
		glVertex3f(-xyz2, xyz2, xyz2);

		//Back
		glColor4f(0, 0, 1, 0.5); //Blue
		glVertex3f(-xyz2, 0, -xyz2);
		glVertex3f(xyz2, 0, -xyz2);
		glVertex3f(xyz2, xyz2, -xyz2);
		glVertex3f(-xyz2, xyz2, -xyz2);
	glEnd();

	glutSwapBuffers();
}

// OpenGL window reshape routine.
void resize(int w, int h)
{
	glViewport(0, 0, w, h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluPerspective(90.0, 1.0, 5.0, 100.0);
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
}

// Routine to output interaction instructions to the C++ window.
void printInteraction(void)
{
	cout << "Interaction:" << endl;
	cout << "Press the l key to rotate camera left around the object once." << endl;
	cout << "Press the r key to rotate camera right around the object once." << endl;
}

void keyInput(unsigned char key, int x, int y)
{
	switch (key)
	{	// use space key to have the animation play
	case 'l':
		animateCamera(1);
		break;
	case 'r':
		animateReverseCamera(1);
		break;
	case 27:
		exit(0);
		break;
	default:
		break;
	}
}

// Main routine.
int main(int argc, char **argv)
{
	glutInit(&argc, argv);

	glutInitContextVersion(4, 0);
	glutInitContextProfile(GLUT_COMPATIBILITY_PROFILE);
	printInteraction();
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);
	glutInitWindowSize(600, 600);
	glutInitWindowPosition(100, 100);
	glutCreateWindow("final0");
	glutDisplayFunc(drawScene);
	glutReshapeFunc(resize);
	glutKeyboardFunc(keyInput);
	glewExperimental = GL_TRUE;
	glewInit();

	setup();

	glutMainLoop();
}
