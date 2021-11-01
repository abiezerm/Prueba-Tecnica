// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Router() {
	$("#userMenu").hide();
	var name = location.hash.replace("#", "");
	var paramtr = name.split("/");
	
	if (App.Controladores[name]) {
		App.Controladores.Activo =name;
		App.Controladores[name]();
	} else if (App.Controladores[paramtr[0]]) {
		App.Controladores.Activo = paramtr[0];
		if (paramtr[2]) {
			// app.contrAct=App.Controladores[paramtr[0]];
			if (paramtr[3]) {
				App.Controladores[paramtr[0]](paramtr[1], paramtr[2], paramtr[3]);
			} else {
				App.Controladores[paramtr[0]](paramtr[1], paramtr[2]);
			}
		} else {
			App.Controladores[paramtr[0]](paramtr[1]);
		}
	} else {
		App.Controladores.Activo = 'Home';
		App.Controladores["Home"]("404");
		name="Home";
	}
	$(".nav-link.text-dark").removeClass("Sel");
	$("#Bt"+name).addClass("Sel");
	document.scrollingElement.scrollTop = 0;
	// actRipple();
}




App = new Vue({
	el: "#App",
	created() {
		this.getClientes();
	},
	data: {
		Controladores: {
			Activo: "",
			Home() {
				console.log("Home");
			},
			Clientes(Funcion, id) {
				console.log("clientes");

			},
			Api() {
				console.log("clientes");
			},
		},
		Clientes: [
			{ "id": 1, "name": "Roman Ferreiras", "email": "referreiras@outlook.com", "phone": "+18099539822", "addresses": null },
			{ "id": 2, "name": "Roman Ferreiras 2", "email": "referreiras@outlook.com", "phone": "+18099539822", "addresses": null },
			{ "id": 3, "name": "Roman Ferreiras 3", "email": "referreiras@outlook.com", "phone": "+18099539822", "addresses": null },
		],
		//Direciones:[],
		Direciones: [{ "id": 1, "street": "Calle respaldo", "number": 3, "city": "Santo Domingo", "state": "DN", "country": "RD", "clientID": 1, "client": null }, { "id": 2, "street": "Calle Defillo ", "number": 34, "city": "Santo Domingo", "state": "DN", "country": "RD", "clientID": 1, "client": null }, { "id": 3, "street": "Av. Bolibar", "number": 785, "city": "Santiago", "state": "ST", "country": "RD", "clientID": 1, "client": null }],
		tblClientesStts: "Browse",
		tblDirecionesStts: "Browse",
		rowSelected: 0,
		rowi: null,
		rowiAddr: null,
		selectedTable: "tCliente",
		rowSelectedAdrr: 0,
		selectedTableAdrr: "",
		tblClientesId:0,
		tblDirecionesId:0,

	},
	methods: {
		getClientes() {
			$.ajax({
				url: "http://localhost:53158/api/ClientsApi",
				method: "GET",
				dataType:"json",
				success(data, estatus) {
					App.Clientes = data
					App.tblClientesStts="Browse";
				},
			});
		},
		guardarNuevoClientes() {
			var h=this.Clientes[this.Clientes.length - 1];
			$.ajax({
				url: "http://localhost:53158/api/ClientsApi",
				method: "POST",
				headers: { 
					'Accept': 'application/json',
					'Content-Type': 'application/json' 
				},
				dataType:"json",
				data: JSON.stringify({"name": h.name, "email": h.email, "phone": h.phone})
				,
				success(data, estatus) {
					App.getClientes();
				},
			});

		},
		guardarClientes() {
			if (this.tblClientesStts == "New") {
				this.guardarNuevoClientes();
			}else if(this.tblClientesStts == "Edit"){
				this.guardarTodosClientes();
			}
		},
		guardarTodosClientes() {
			// delete(this.Clientes[this.tblClientesId].addresses);
			$.ajax({
				url: "http://localhost:53158/api/ClientsApi/"+this.tblClientesId,
				method: "put",
				headers: { 
					'Accept': 'application/json',
					'Content-Type': 'application/json' 
				},
				dataType:"json",
				data:JSON.stringify( this.Clientes.find(i=>i.id==this.tblClientesId) ),
				success(data, estatus) {
					App.getClientes();
				},
			});
			[].find()
		},
		cancelarCambiosCliente(){
			this.tblClientesStts = "Browse";
			this.getClientes();
		},
		nuevoCliente() {
			if (this.tblClientesStts == "Browse") {
				this.tblClientesStts = "New";
				this.Clientes.push({"name": "", "email": "", "phone": ""});

				//row,i,'tClientes'

				this.selectedTable = 'tClientes';
				this.rowSelected = this.Clientes.length-1;
				// console.log(row);
				this.rowi = this.Clientes[this.Clientes.length-1];
				//this.getDireciones(row.id);
				this.showDetailPanel = true;
			}

		},		
		getDireciones(id) {
			$.ajax({
				url: "http://localhost:53158/api/AddressesApi",
				method: "GET",
				data: {
					clientID: id
				},
				success(data, estatus) {

					App.Direciones = data;
					App.tblDirecionesStts = "Browse";
					
				},
			});

		},


		guardarNuevoDireciones() {
			var h=this.Direciones[this.Direciones.length - 1];
			h.clientID=this.rowi.id;
			
			$.ajax({
				url: "http://localhost:53158/api/AddressesApi",
				method: "POST",
				headers: { 
					'Accept': 'application/json',
					'Content-Type': 'application/json' 
				},
				dataType:"json",
				data: JSON.stringify(h)
				,
				success(data, estatus) {
					App.getDireciones(App.rowi.id);
				},
			});

		},
		guardarDireciones() {
			if (this.tblDirecionesStts == "New") {
				this.guardarNuevoDireciones();
			}else if(this.tblDirecionesStts == "Edit"){
				this.guardarTodosDireciones();
			}
		},
		guardarTodosDireciones() {
			//this.Direciones[this.tblDirecionesId].client="";
			delete(this.Direciones.find(i=>i.id==this.tblDirecionesId).client);
			$.ajax({
				url: "http://localhost:53158/api/AddressesApi/"+this.tblDirecionesId,
				method: "put",
				headers: { 
					'Accept': 'application/json',
					'Content-Type': 'application/json' 
				},
				dataType:"json",
				data:JSON.stringify(this.Direciones.find(i=>i.id==this.tblDirecionesId)),
				success(data, estatus) {
					App.getDireciones(App.rowi.id);
				},
			});

		},
		cancelarCambiosDireciones(){
			this.tblDirecionesStts = "Browse";
			App.getDireciones(App.rowi.id);
		},
		nuevoDireciones() {
			if (this.tblDirecionesStts == "Browse") {
				this.tblDirecionesStts = "New";
				this.Direciones.push({"street": "", "number":1, "city": "", "state": "", "country": "", "clientID":this.rowi.id });

				//row,i,'tClientes'

				this.selectedTableAdrr = 'tDirecciones';
				this.rowSelectedAdrr = this.Direciones.length-1;
				// console.log(row);
				this.rowiAddr = this.Direciones[this.Direciones.length-1];
				//this.getDireciones(row.id);
				this.showDetailPanel = true;
			}

		},



		cambioCliente(i) {
			if (this.tblClientesStts == "Browse") {
				this.tblClientesStts = "Edit";
				this.tblClientesId=this.Clientes[i].id;
				console.log(this.tblClientesId);
			}
		},
		cambioDireccion(i) {
			if (this.tblDirecionesStts == "Browse") {
				this.tblDirecionesStts = "Edit";
				this.tblDirecionesId=this.Direciones[i].id;
			}
		},
		showDetailClientes(row, i, sT) {
			this.selectedTable = sT;
			this.rowSelected = i;
			// console.log(row);
			this.rowi = row;
			this.getDireciones(row.id);
			this.showDetailPanel = true;

		},
		showDetailDirecciones(row, i, sT) {
			this.selectedTableAdrr = sT;
			this.rowSelectedAdrr = i;
			console.log(row);
			this.rowiAddr = row;
			//this.getDireciones(row.id);
			//this.showDetailPanel = true;

		},
		hideDetail() {
			this.showDetailPanel = false;
		},
	},
	/*
 * AFTER-RENDER
 */
	updated: function () {
		this.$nextTick(function () {
			// actRipple();
		});
	}
});
window.onhashchange = Router;
window.setTimeout(Router, 250);