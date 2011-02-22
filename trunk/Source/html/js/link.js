var site = {
	route:[],
	go:function(routeId)
		{
			if(this.route[routeId])
			{
				alert(this.route[routeId]);
			}
			else
			{
				alert('링크가 존재하지 않습니다.')
			}
		}
}

site.route['gnb'] = 'http://고용노동부';
site.route['ksi'] = 'http://한국산업인력공단';
site.route['fesco'] = 'http://fesco';
site.route['sh'] = 'http://주상하이총영사관';
site.route['kotra'] = 'http://코트라';
site.route['51job'] = 'http://51job';
site.route['hkg'] = 'http://한국 관광공사';
site.route['shk'] = 'http://상해한국';
site.route['exc'] = 'http://expochina';			
site.route['info'] = 'http://문의하기';						
site.route['globaljob'] = 'http://global';	 		
site.route['chinajob'] = 'http://차이나잡고';			
site.route['sitemap'] = 'http://사이트맵';