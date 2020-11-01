<%@ page contentType="text/html; charset=utf-8" pageEncoding="utf-8"%>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Insert title here</title>
	<script src="nicEdit.js" type="text/javascript"></script>
	<script type="text/javascript">
		bkLib.onDomLoaded(function() {
			new nicEditor({ 
				fullPanel: true, 
				iconsPath : 'nicEditorIcons.gif', 
				uploadURI: '/EShopV21/nic-editor/upload.htm' 
			}).panelInstance('content');
		});
	</script>
</head>
<body>
<form>
	<textarea id="content" rows="5" cols="50"></textarea>
	<br>
	<input type="submit" value="Save">
</form>
</body>
</html>