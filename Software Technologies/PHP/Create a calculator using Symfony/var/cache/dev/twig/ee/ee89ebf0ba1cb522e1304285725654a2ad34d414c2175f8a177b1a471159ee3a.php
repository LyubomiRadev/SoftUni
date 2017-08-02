<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_283c8bbb70a46019b153a00301b6e7bcd7e32171adbb33b9c63e862a0b5b3056 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_1c3d1f9267da64d019d0d623bc61680f4ea0e7efe536540b447d522e59fd0660 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1c3d1f9267da64d019d0d623bc61680f4ea0e7efe536540b447d522e59fd0660->enter($__internal_1c3d1f9267da64d019d0d623bc61680f4ea0e7efe536540b447d522e59fd0660_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_1c3d1f9267da64d019d0d623bc61680f4ea0e7efe536540b447d522e59fd0660->leave($__internal_1c3d1f9267da64d019d0d623bc61680f4ea0e7efe536540b447d522e59fd0660_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_175ffdbeab1a15fefee0ca4bebace14541d3294435c7fbd830d7860015a2d044 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_175ffdbeab1a15fefee0ca4bebace14541d3294435c7fbd830d7860015a2d044->enter($__internal_175ffdbeab1a15fefee0ca4bebace14541d3294435c7fbd830d7860015a2d044_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_175ffdbeab1a15fefee0ca4bebace14541d3294435c7fbd830d7860015a2d044->leave($__internal_175ffdbeab1a15fefee0ca4bebace14541d3294435c7fbd830d7860015a2d044_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_e41add31540f9fa783997420077ffc8d47cb6206082d9752f3268743fdb1460d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e41add31540f9fa783997420077ffc8d47cb6206082d9752f3268743fdb1460d->enter($__internal_e41add31540f9fa783997420077ffc8d47cb6206082d9752f3268743fdb1460d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_e41add31540f9fa783997420077ffc8d47cb6206082d9752f3268743fdb1460d->leave($__internal_e41add31540f9fa783997420077ffc8d47cb6206082d9752f3268743fdb1460d_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_695f63ea68a37ba2b1e8c276069868bdc7f424cef25a157fb0719674e6eb236f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_695f63ea68a37ba2b1e8c276069868bdc7f424cef25a157fb0719674e6eb236f->enter($__internal_695f63ea68a37ba2b1e8c276069868bdc7f424cef25a157fb0719674e6eb236f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_695f63ea68a37ba2b1e8c276069868bdc7f424cef25a157fb0719674e6eb236f->leave($__internal_695f63ea68a37ba2b1e8c276069868bdc7f424cef25a157fb0719674e6eb236f_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
