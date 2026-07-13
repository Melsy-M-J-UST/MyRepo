using DIDemo;
//deeply coupled cannot be easily tested or maintained
Shape s = new Triangle();
DrawingApp app = new DrawingApp(s);
app.DrawShapes();