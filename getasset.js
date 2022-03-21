const fs = require('fs');
const https = require('https');
const zlib = require('zlib');

const https_redir = require('follow-redirects').https;
function gzipRequest(options, payload) {
	return new Promise(function (resolve, reject) {
			const req = https_redir.request(options, function (res) {
					if (res.headers['content-encoding'] == 'gzip') {
							var gunzip = zlib.createGunzip();
							res.pipe(gunzip);
							res = gunzip;
					}

					var data = '';
					res.on('data', (chunk) => {
							data += chunk;
					}).on('end', () => {
							//console.log(data);
							resolve(data);
					}).on('error', (err) => {
							reject(err);
					});
			}).on('error', function (err) {
					reject(err);
			});
			if (payload)
					req.write(payload);
			req.end();
	});
}

async function soundAssetFromId(assetId) {
	const options = {
			hostname: "www.roblox.com",
			path: `/library/${assetId}/`,
			method: 'GET',
			headers: {
					'Connection': "keep-alive",
					'Pragma': "no-cache",
					'Cache-Control': "no-cache",
					'Upgrade-Insecure-Requests': 1,
					'User-Agent': "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36",
					'Accept': "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*; q = 0.8, application / signed - exchange; v = b3; q = 0.9",
					'Sec-Fetch-Site': "none",
					'Sec-Fetch-Mode': "navigate",
					'Sec-Fetch-User': "?1",
					'Sec-Fetch-Dest': "document",
					'Accept-Encoding': "gzip",
					'Accept-Language': "en-US,en;q=0.9"
			}
	};

	try {   
			const page = await gzipRequest(options);

			const contentTag = 'data-mediathumb-url="';
			var contentIndex = page.indexOf(contentTag);
			if (contentIndex == -1) {
					//console.log(page);
					return "Could not find content.";
			}
			contentIndex += contentTag.length;
			const contentUrl = page.substring(contentIndex, page.indexOf('"', contentIndex + 1));
			//console.log(contentUrl);

			return contentUrl;
	} catch (err) {
			return "RBX" + err;
	}
}

async function returnasset() {
  var argsID = process.argv[2]
  let results = [];
  results.push(await soundAssetFromId(argsID));
  console.log(results.join("\n"));
}
returnasset()