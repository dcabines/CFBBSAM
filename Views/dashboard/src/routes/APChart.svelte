<script>
	import { onMount } from 'svelte';
  import * as d3 from "d3";
	import * as Plot from "@observablehq/plot";

  onMount(async () => {
    const data = await d3.csv('/data/AP.csv');
    console.log(data);

    const stacked = Plot.barY(
      data,
      Plot.groupX({ y: "count" }, { x: "island", fill: "species" })
    ).plot({ color: { legend: true } })


    const plot = Plot.rectY({length: 10000}, Plot.binX({y: "count"}, {x: d3.randomNormal()})).plot();
    const div = document.querySelector("#myplot");
    const mystack = document.querySelector("#mystack");

    if(div) div.append(plot);
    if(mystack) mystack.append(stacked);

  });
</script>

<div id="myplot"></div>
<div id="mystack"></div>