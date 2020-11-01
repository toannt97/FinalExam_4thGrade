package eshop.admin.action;

import javax.servlet.ServletContext;

import org.apache.struts2.convention.annotation.Action;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.multipart.MultipartFile;

import com.opensymphony.xwork2.ActionSupport;

import eshop.util.UploadFile;
import eshop.util.XResponse;

@Controller
@RequestMapping("/nic-editor/upload")
public class NicEditorController{
	@Autowired
	ServletContext application;

	@ResponseBody
	public String nicEditorUpload(@RequestParam MultipartFile image) throws Exception {
		String fileName = System.currentTimeMillis() + image.getOriginalFilename();
		String path = "images/nic-images/" + fileName;		
		image.transferTo(new File(application.getRealPath(path)));
		return "<script>top.nicUploadButton.statusCb({ done:1, width:'300', url:'" + path + "'});</script>";
	}
}
