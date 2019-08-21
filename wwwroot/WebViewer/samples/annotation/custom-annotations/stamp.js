window.createStampTool = function(instance) {
  var docViewer = instance.docViewer;
  var annotManager = instance.annotManager;
  var Annotations = instance.Annotations;
  var Tools = instance.Tools;

  var CustomStampCreateTool = function() {
    Tools.GenericAnnotationCreateTool.call(this, docViewer, Annotations.StampAnnotation);
    delete this.defaults.StrokeColor;
    delete this.defaults.FillColor;
    delete this.defaults.StrokeThickness;
  }

  CustomStampCreateTool.prototype = new Tools.GenericAnnotationCreateTool();

  CustomStampCreateTool.prototype.mouseLeftDown = Tools.AnnotationSelectTool.prototype.mouseLeftDown;

  CustomStampCreateTool.prototype.mouseMove = Tools.AnnotationSelectTool.prototype.mouseMove;

  CustomStampCreateTool.prototype.mouseLeftUp = function(e) {
    Tools.GenericAnnotationCreateTool.prototype.mouseLeftDown.call(this, e);
    var annotation;
    if (this.annotation) {
      var width = 212;
      var height = 60;
      var rotation = this.docViewer.getCompleteRotation(this.annotation.PageNumber) * 90;
      this.annotation.Rotation = rotation;
      if (rotation === 270 || rotation === 90) {
        var t = height;
        height = width;
        width = t;
      }
      // 'ImageData' can be a bas64 ImageString or an URL. If it's an URL, relative paths will cause issues when downloading
      this.annotation.ImageData = stampImage;
      this.annotation.Width = width;
      this.annotation.Height = height;
      this.annotation.X -= width / 2;
      this.annotation.Y -= height / 2;
      this.annotation.MaintainAspectRatio = true;
      annotation = this.annotation;
    }

    Tools.GenericAnnotationCreateTool.prototype.mouseLeftUp.call(this, e);

    if (annotation) {
      annotManager.redrawAnnotation(annotation);
    }
  }

  return new CustomStampCreateTool();
};

var stampImage = 'data:image/png;base64,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';