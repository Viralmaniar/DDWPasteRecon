# DDWPasteRecon

Pastesites are websites that allows users to share plain text through public posts called “pastes.” 

Once attackers compromise the external perimeter and gain access to the internal resources they release the part of data on the "paste" sites like pastebin or hastebin. As these hackers or malicious groups publish dumps on such sites others users can see sensitive information through paste sites.

With various malicious groups now using these services as communication channels, temporary storage or sharing, and various other sources being used to trade POC code, I thought it would be a good idea to have an easy tool to help organisations Blue and Red Teams to have a visibility into these sites via Google dorks. 

DDWPasteRecon tool will help you identify code leak, sensitive files, plaintext passwords, password hashes. It also allow member of SOC & Blue Team to gain situational awareness of the organisation's web exposure on the pastesites. It Utilises Google's indexing of pastesites to gain targeted intelligence of the organisation. Blue & SOC teams can collect and analyse data from these indexed pastesites to better protect against unknown threats.

![image](https://user-images.githubusercontent.com/3501170/162573567-63605637-0c05-4f80-bb7e-f8e67bbe9370.png)

Tool will be able to track the sites that've been searched for sensitive information. 

- Searched sites will be marked with red coloured button as shown below:

![image](https://user-images.githubusercontent.com/3501170/162575090-68617291-5ac5-42c0-9dd4-3272e412dc5f.png)

- Pastesites remaining for the searches:

![image](https://user-images.githubusercontent.com/3501170/162575120-fa098276-5b5c-446b-8029-b13bfbfde9ff.png)


# List of Online IDEs, Paste sites and Carder forums

DDWPasteRecon uses following sites to perform searches:

```
•	gist.github.com
•	paste.mozilla.org
•	ide.geeksforgeeks.org
•	codepen.io
•	pastebin.com
•	gitlab.com
•	repl.it
•	paste.ubuntu.com
•	justpaste.it
•	jsfiddle.net
•	paste.centos.org
•	jsbin.com
•	pastelink.net
•	codebeautify.org
•	controlc.com
•	invent.kde.org
•	ideone.com
•	paste.rohitab.com
•	codeshare.io
•	paste.opensuse.org
•	dotnetfiddle.net
•	notes.io
•	snipplr.com
•	paste2.org
•	hastebin.com
•	ivpaste.com
•	phpfiddle.org
•	codepad.org
•	justpaste.me
•	pastebin.osuosl.org
•	www.geany.org
•	bpa.st
•	paste.ofcode.org
•	paste.ee
•	dpaste.org
•	friendpaste.com
•	defuse.ca
•	dpaste.com
•	pastebin.icoder.uz
•	cl1p.net
•	pastie.org
•	pastecode.io
•	ghostbin.com
•	www.heypasteit.com
•	pastebin.fr
•	pasteall.org
•	jsitor.com
•	termbin.com
•	p.ip.fi
•	cutapaste.net
•	www.textsnip.com
•	paste.lisp.org
•	paste.sh
•	dumpz.org
•	paste.jp
•	paste.xinu.at
•	paste.debian.net
•	vpaste.net
•	paste.pound
•	paste.org.ru
•	apaste.info
•	quickhighlighter.com
•	sprunge.us
•	commie.io
•	everfall.com
•	paste.strictfp.com
•	kpaste.net
•	fferen.kpaste.net
•	eilios.kpaste.net
•	rathena.kpaste.net
•	paste.frubar.net
•	pst.klgrth.io
•	www.pastebin.pt
•	nopaste.me
•	99paste.com
•	n0paste.tk
•	pastecode.fr
•	pastecode.ru
•	www.paste.lv
•	pastesqf.com
•	tutpaste.com
•	paste.scratchbook.ch
•	bitbin.it
•	privatebin.net
•	0bin.net
•	sebsauvage.netpaste
•	pastefs.com
•	slexy.org
•	pasteio.com
•	www.paste4btc.com
•	paste.pocoo.org
•	pastie.textmate.org
•	paste.bradleygill.com
•	etherpad.com
•	textsnip.com
•	pastebin.ca
•	squadedit.com
•	tinypaste.com
•	vyew.com
•	copytaste.com
•	drop.io
•	snipt.net
•	pastee.org
•	heypasteit.com
•	pastebay.org
•	pastehtml.com
•	codeupload.com
•	snipsource.com
•	dragbox.org
•	chopapp.com
•	drupalbin.com
•	nopaste.info
•	privatepaste.com
•	codekeep.net
•	snippets.dzone.com
•	everfall.com/paste
•	source.virtser.net
•	codesnipp.it
•	hpaste.org
•	9url.us
•	tidypub.org
•	lettur.com
•	sebsauvage.net/paste
•	www.pastefs.com
•	pasted.co
•	everfall.compaste
•	lpaste.net
•	pastebin.centos.org
•	p.hgc.host
•	riskmitigation.ch
•	paste.bitlair.nl
•	www.posu.org
•	pasting.djstey.com
•	paste.balbinus.org
```

# Screenshots

Searching pastesites using primary domain for a target organisation:

![image](https://user-images.githubusercontent.com/3501170/162573895-2d4e627c-8a40-4f47-94e9-c2a3cb4acc2a.png)

Searching pastesites with password keyword for a target organisation:
 
![image](https://user-images.githubusercontent.com/3501170/162574414-a652626d-dd1d-4e6c-b0dd-773e3a223d35.png)

Getting access to sensitive information:

![image](https://user-images.githubusercontent.com/3501170/162574593-993d2a5a-0bbf-4378-9e00-886d90a65cb0.png)

# How to use this tool?

Step1: Download the file from Release section: https://github.com/Viralmaniar/DDWPasteRecon/releases/download/v1.0.0/DDWPasteRecon.exe

Step2: Run the EXE file

Step3: Enter the target domain or keywords along with the organisation name

Step4: Click on different buttons in the tool to find information

Step5: In case of Google Captcha simply click on the puzzle and move ahead

# Questions?

Twitter: https://twitter.com/maniarviral <br>
LinkedIn: https://au.linkedin.com/in/viralmaniar

# Contribution & License

<a rel="license" href="http://creativecommons.org/licenses/by/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by/4.0/80x15.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by/4.0/">Creative Commons Attribution 4.0 International License</a>.</br>
Want to contribute? Please fork it and hit up with a pull request.

Any suggestions or ideas for this tool are welcome - just tweet me on [@ManiarViral](https://twitter.com/maniarviral)
