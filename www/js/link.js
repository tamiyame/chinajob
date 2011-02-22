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