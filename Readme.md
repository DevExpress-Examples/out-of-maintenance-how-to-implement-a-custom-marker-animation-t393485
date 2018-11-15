<!-- default file list -->
*Files to look at*:

* **[CircularMarkerSlideFromLeftAnimation.cs](./CS/CustomCircularSeriesAnimationSample/CircularMarkerSlideFromLeftAnimation.cs) (VB: [CircularMarkerSlideFromLeftAnimation.vb](./VB/CustomCircularSeriesAnimationSample/CircularMarkerSlideFromLeftAnimation.vb))**
<!-- default file list end -->
# How to: Implement a Custom Marker Animation


This example demonstrates how to implement the <strong>Slide from Left</strong> animation for series views supported by the Circular (Radar and Polar) diagrams.


<h3>Description</h3>

<p>&nbsp;To implement a custom&nbsp;marker&nbsp;animation, create a class derived from the&nbsp;<strong>CircularMarkerAnimationBase</strong>&nbsp;class and override the base class'&nbsp;<strong>ApplyState&nbsp;</strong>method.</p>
<p>The following objects are passed to this method as parameters.<br>- sceneModifier - this object allows you to apply the required transformations to your series.<br>- diagramBounds - this object specifies bounds of the diagram on which an animated series is drawn.<br>-&nbsp;markerParameters - this object stores parameters of an animating marker, e.g. the marker's bounds and location.<br>- progress - this value specifies the current progress of the animation.</p>

<br/>


