package eshop.controller;

import java.io.File;

import javax.servlet.ServletContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.multipart.MultipartFile;

@Controller
public class NicEditorController{
	@Autowired
	ServletContext application;

	@ResponseBody
	@RequestMapping("nic-editor/upload")
	public String nicEditorUpload(@RequestParam MultipartFile image) throws Exception {
		String fileName = System.currentTimeMillis() + image.getOriginalFilename();
		String path = "nicEditor/images/" + fileName;	
		image.transferTo(new File(application.getRealPath(path)));
		return "<script>top.nicUploadButton.statusCb({ done:1, width:'300', url:'../" + path + "'});</script>";
	}
}
